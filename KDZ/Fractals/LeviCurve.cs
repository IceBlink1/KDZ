using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Fractals
{
    public class LeviCurve : Fractal
    {
        public LeviCurve(Color[] colour, Graphics g, Pen p, int width, int heigth) : base(colour, g, p, width, heigth)
        {

        }
        public override void Draw(int iterations, int length, PointF[] points, double angle)
        {
            P.Color = Gradient[Gradient.Length - iterations];
            if (iterations == 1)
                G.DrawLine(P, (int)points[0].X, (int)points[0].Y, (int)points[1].X, (int)points[1].Y);
            else
            {
                int xx = (int)(((points[0].X + points[1].X) / 2) + ((points[1].Y - points[0].Y) / 2));
                int yy = (int)(((points[0].Y + points[1].Y) / 2) - ((points[1].X - points[0].X) / 2));
                PointF[] p1 = new PointF[] {points[0], new PointF(xx, yy)};
                PointF[] p2 = new PointF[] {new PointF(xx, yy), points[1]};
                Draw(iterations - 1, length, p1, 0);
                Draw(iterations - 1, length, p2, 0);
            }
        }
    }
}
