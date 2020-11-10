using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SerialVisualizer.Extensions
{
    public static class PointExtensions
    {
        public static PointF Add(this PointF addend1, PointF addend2)
        {
            return new PointF(addend1.X + addend2.X, addend1.Y + addend2.Y);
        }
        public static PointF Add(this PointF addend1, float addend2X, float addend2Y)
        {
            return new PointF(addend1.X + addend2X, addend1.Y + addend2Y);
        }

        public static PointF Add(this PointF addend1, float addend2XY)
        {
            return new PointF(addend1.X + addend2XY, addend1.Y + addend2XY);
        }

        public static PointF[] CreateIsoscelesTriangle(this PointF baseEdge, float height, float width)
        {
            float halfWidth = Math.Abs(width / 2);
            return new PointF[]
            {
                baseEdge,
                baseEdge.Add(halfWidth, height),
                baseEdge.Add(halfWidth * -1, height)
            };
        }
    }
}
