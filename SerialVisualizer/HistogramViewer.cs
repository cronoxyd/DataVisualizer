using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialVisualizer.Extensions;

namespace SerialVisualizer
{
    public partial class HistogramViewer : Control
    {
        private float[] _data;
        private Color _barcolor = Color.Black;
        private bool _colorminmax = true;
        private Color _maxcolor = Color.Red;
        private Color _mincolor = Color.Blue;
        private bool _displayminmax = true;
        private bool _minmaxhold = false;

        private float[] _maxdata;
        private float[] _mindata;

        public float[] MinData
        {
            get
            {
                return _mindata;
            }
        }

        public float[] MaxData
        {
            get
            {
                return _maxdata;
            }
        }

        [Category("Behavior"), Description("Whether to display the minimum and maximum values as text.")]
        public bool DisplayMinMax
        {
            get => _displayminmax;
            set
            {
                _displayminmax = value;
                Refresh();
            }
        }

        [Category("Data"), Description("The values of the histogram")]
        public float[] Data
        {
            get => _data;
            set
            {
                _data = value;
                Refresh();
            }
        }

        [Category("Appearance"), Description("Color of the histogram bars")]
        public Color BarColor
        {
            get => _barcolor;
            set
            {
                _barcolor = value;
                Refresh();
            }
        }

        [Category("Behavior"), Description("Whether to use special colors for the bars displaying the minimum and maximum values of the data.")]
        public bool ColorMinMax
        {
            get => _colorminmax;
            set
            {
                _colorminmax = value;
                Refresh();
            }
        }

        [Category("Appearance"), Description("The color of the bars representing the smallest value in the data.")]
        public Color MinColor
        {
            get => _mincolor;
            set
            {
                _mincolor = value;
                Refresh();
            }
        }

        [Category("Appearance"), Description("The color of the bars representing the biggest value in the data.")]
        public Color MaxColor
        {
            get => _maxcolor;
            set
            {
                _maxcolor = value;
                Refresh();
            }
        }

        [Category("Behavior"), Description("Whether the histogram's maximum is calculated automatically.")]
        public bool AutoMax { get; set; } = true;

        [Category("Behavior"), Description("Whether the histogram's minimum is calculated automatically.")]
        public bool AutoMin { get; set; } = false;

        public bool MinMaxHold
        {
            get => _minmaxhold;
            set
            {
                if (value != _minmaxhold)
                {
                    MinMemory = float.MaxValue;
                    MaxMemory = float.MinValue;
                }
                _minmaxhold = value;
                Refresh();
            }
        }

        [Category("Data"), Description("The maximum value of any bar in the histogram.")]
        public float Maximum { get; set; } = 1000;

        [Category("Data"), Description("The minimum value of any bar in the histogram.")]
        public float Minimum { get; set; } = 0;

        private float MaxMemory = float.MinValue;
        private float MinMemory = float.MaxValue;

        public HistogramViewer()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.Clear(BackColor);
            if (_data == null) return;
            if (_data.Length < 1) return;

            float barWidth = Width / _data.Length;

            float maxDataValue = Data.Max();
            float maxDisplayValue = (AutoMax ? maxDataValue : Maximum);

            float minDataValue = Data.Min();
            float minDisplayValue = (AutoMin ? minDataValue : Minimum);

            if (MinMaxHold)
            {
                if (maxDataValue > MaxMemory) MaxMemory = maxDataValue;
                if (minDataValue < MinMemory) MinMemory = minDataValue;

                // If there is no saved data or the lengths don't match, reset to current data
                if ((_maxdata?.Length ?? -1) != Data.Length) _maxdata = (float[]) Data.Clone();
                if ((_mindata?.Length ?? -1) != Data.Length) _mindata = (float[]) Data.Clone();

                for (int i = 0; i < Data.Length; i++)
                {
                    float dataPoint = Data[i];
                    if (dataPoint > _maxdata[i]) _maxdata[i] = dataPoint;
                    if (dataPoint < _mindata[i]) _mindata[i] = dataPoint;
                }
            }

            float displayRange = Math.Abs(maxDataValue - minDataValue);

            for (int i = 0; i < _data.Length; i++)
            {
                float currentDataValue = _data[i];
                float barRelativeHeight = (currentDataValue / maxDisplayValue);
                PointF basePosition = new PointF(barWidth * i, 0);
                Color barColor = BarColor;
                if (ColorMinMax)
                {
                    if (currentDataValue == maxDataValue) barColor = MaxColor;
                    else if (currentDataValue == minDataValue) barColor = MinColor;
                }
                PointF barPosition = basePosition.Add(0, Height - (Height * barRelativeHeight));
                SizeF barSize = new SizeF(barWidth, Height * barRelativeHeight);
                pe.Graphics.FillRectangle(
                    new SolidBrush(barColor),
                    new RectangleF(barPosition, barSize)
                );

                if (MinMaxHold)
                {
                    float currentMaxValue = _maxdata[i];
                    float currentMinValue = _mindata[i];

                    float relativeMaxHeight = (currentMaxValue / maxDisplayValue);
                    float relativeMinHeight = (currentMinValue / maxDisplayValue);

                    /*
                    PointF maxLineStart = basePosition.Add(0, Height - (Height * relativeMaxHeight));
                    PointF minLineStart = basePosition.Add(0, Height - (Height * relativeMinHeight));

                    pe.Graphics.DrawLine(
                        new Pen(new SolidBrush(MaxColor)), 
                        maxLineStart, 
                        maxLineStart.Add(barWidth, 0)
                    );

                    pe.Graphics.DrawLine(
                        new Pen(new SolidBrush(MinColor)),
                        minLineStart,
                        minLineStart.Add(barWidth, 0)
                    );
                    */

                    PointF maxPoint = basePosition.Add(barWidth / 2, Height - (Height * relativeMaxHeight));
                    PointF minPoint = basePosition.Add(barWidth / 2, Height - (Height * relativeMinHeight));
                    pe.Graphics.FillPolygon(new SolidBrush(MaxColor), maxPoint.CreateIsoscelesTriangle(-10, 10));
                    pe.Graphics.FillPolygon(new SolidBrush(MinColor), minPoint.CreateIsoscelesTriangle(10, 10));
                }
            }

            if (DisplayMinMax)
            {
                string strMax = "Max: " + (MinMaxHold ? MaxMemory : maxDataValue);
                string strMin = "Min: " + (MinMaxHold ? MinMemory : minDataValue);
                PointF strMaxPos = new Point(Padding.Left, Padding.Top);
                PointF strMinPos = strMaxPos.Add(0, Font.GetHeight());

                pe.Graphics.DrawString(strMax, Font, new SolidBrush(ForeColor), strMaxPos);
                pe.Graphics.DrawString(strMin, Font, new SolidBrush(ForeColor), strMinPos);
            }
        }

        public void ResetMinMax()
        {
            _maxdata = null;
            _mindata = null;
            MinMemory = float.MaxValue;
            MaxMemory = float.MinValue;
        }
    }
}
