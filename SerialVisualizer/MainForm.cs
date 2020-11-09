using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace SerialVisualizer
{
    public partial class MainForm : Form
    {
        public SerialPort CurrentPort { get; private set; } = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
            RefreshPortList();
        }

        private void RefreshPortList()
        {
            string originalSelection = (string) PortList_comboBox.SelectedItem;
            PortList_comboBox.Items.Clear();
            PortList_comboBox.Items.AddRange(SerialPort.GetPortNames());
            if (string.IsNullOrWhiteSpace(originalSelection))
            {
                if (PortList_comboBox.Items.Count > 0) PortList_comboBox.SelectedIndex = 0;
            } else
            {
                int originalSelectionIndex = PortList_comboBox.Items.IndexOf(originalSelection);
                if (originalSelectionIndex != -1) PortList_comboBox.SelectedIndex = originalSelectionIndex;
            }            
        }

        private void RefreshList_button_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }

        private void OpenList_button_Click(object sender, EventArgs e)
        {
            if (!CurrentPort.IsOpen)
            {
                CurrentPort = new SerialPort((string) PortList_comboBox.SelectedItem, (int) BaudRate_numericUpDown.Value);
                CurrentPort.Open();
                OpenClose_button.Text = "Close";
                PortList_comboBox.Enabled = false;
                RefreshList_button.Enabled = false;
                BaudRate_numericUpDown.Enabled = false;
                CurrentPort.DataReceived += CurrentPort_DataReceived;
            } else
            {
                OpenClose_button.Text = "Closing...";
                Thread closeThread = new Thread(new ThreadStart(SerialPort_Close));
                closeThread.Start();
            }
        }

        private void SerialPort_Close()
        {
            CurrentPort.Close();

            Invoke(new Action(() =>
            {
                OpenClose_button.Text = "Open";
                PortList_comboBox.Enabled = true;
                RefreshList_button.Enabled = true;
                BaudRate_numericUpDown.Enabled = true;
            }));
        }

        private void CurrentPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    string incomingLine = CurrentPort.ReadLine();
                    string[] fields = incomingLine.Split(",")
                        .Where(f => !string.IsNullOrWhiteSpace(f))
                        .Where(f => Regex.IsMatch(f, @"^\d+([.]\d+)?$"))
                        .ToArray();
                    float[] fieldsNum = fields.Select(f => float.Parse(f)).ToArray();

                    Invoke(new Action(() =>
                    {
                        histogramViewer1.Data = fieldsNum;
                    }));
                }

            } catch (OperationCanceledException oce) {
            } catch (ObjectDisposedException ode) { }
        }

        private void PortList_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CurrentPort.IsOpen) OpenClose_button.Enabled = PortList_comboBox.SelectedIndex >= 0;
        }

        private void HistogramAutoMax_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            histogramViewer1.AutoMax = HistogramAutoMax_checkBox.Checked;
            HistogramMax_numericUpDown.Enabled = !HistogramAutoMax_checkBox.Checked;
        }

        private void HistogramMax_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!HistogramAutoMax_checkBox.Checked) histogramViewer1.Maximum = (float) HistogramMax_numericUpDown.Value;
        }

        private void MinMaxHold_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            histogramViewer1.MinMaxHold = MinMaxHold_checkBox.Checked;
        }
    }
}
