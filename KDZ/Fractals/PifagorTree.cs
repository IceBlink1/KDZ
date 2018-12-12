using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Fractals
{
    public class PifagorTree : Fractal
    {
        private double diminishingCoefficient = 0.7;
        private double ang1 = Math.PI / 4;
        private double ang2 = Math.PI / 6;

        public double Ang1
        {
            get { return ang1; }
            set { ang1 = value; }
        }

        public double Ang2
        {
            get { return ang2; }
            set { ang2 = value; }
        }
        public double DiminishingCoefficient
        {
            get { return diminishingCoefficient; }
            set { diminishingCoefficient = value; }
        }
        public PifagorTree(Color[] colour, Graphics g, Pen p, int width, int heigth) : base(colour, g, p, width, heigth)
        {

        }
        public override void Draw(int iterations, int length, PointF[] points, double angle)
        {

            P.Color = Gradient[Gradient.Length - iterations];
            length = (int)(length * DiminishingCoefficient);
            int x = (int)points[0].X;
            int y = (int)points[0].Y;

            int
                xnew = (int)Math.Round(x + length * Math.Cos(angle)),
                ynew = (int)Math.Round(y - length * Math.Sin(angle));


            G.DrawLine(P, x, y, xnew, ynew);
            if (iterations == 1)
            {
                P.Color = Gradient[0];
            }
            else
            {
                Draw(iterations - 1, (int)(length * DiminishingCoefficient), new PointF[] { new PointF(xnew, ynew) }, angle + ang1);
                Draw(iterations - 1, (int)(length * DiminishingCoefficient), new PointF[] { new PointF(xnew, ynew) }, angle - ang2);
            }
        }
    }
}
