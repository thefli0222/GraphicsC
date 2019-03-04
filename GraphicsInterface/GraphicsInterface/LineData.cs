using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsInterface
{
    class LineData
    {
        double startX;
        double startY;
        double endX;
        double endY;


        public LineData(double startX, double startY, double endX, double endY)
        {
            this.StartX = startX;
            this.StartY = startY;
            this.EndX = endX;
            this.EndY = endY;
        }

        public double StartX { get => startX; set => startX = value; }
        public double StartY { get => startY; set => startY = value; }
        public double EndX { get => endX; set => endX = value; }
        public double EndY { get => endY; set => endY = value; }


        public double[] line_intersection(LineData otherLine)
        {

            double[] xdiff = new double[2];
            double[] ydiff = new double[2];

            xdiff[0] = this.startX - this.endX;
            xdiff[1] = otherLine.startX - otherLine.endX;

            ydiff[0] = this.startY - this.endY;
            ydiff[1] = otherLine.startY - otherLine.endY;


            double div = det(xdiff, ydiff);
            if (div == 0) {
                return null;
            }

            double[] xdiff1 = new double[2];
            double[] ydiff1 = new double[2];

            xdiff1[0] = this.startX;
            xdiff1[1] = this.endX;

            ydiff1[0] = this.startY;
            ydiff1[1] = this.endY;

            double[] xdiff2 = new double[2];
            double[] ydiff2 = new double[2];

            xdiff2[0] = this.startX;
            xdiff2[1] = this.endX;

            ydiff2[0] = this.startY;
            ydiff2[1] = this.endY;

            double[] d = new double[2];
            d[0] = det(xdiff1, xdiff1);
            d[1] = det(xdiff2, ydiff2);
            double x = det(d, xdiff) / div;
            double y = det(d, ydiff) / div;


            double[] ret = { x, y };
            return ret;
        }

        private double det(double[] x, double[] y)
        {
            return x[0] * y[1] - y[0] * x[1];
        }

    }




}
