using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Fractals
{
    public class CircleFractal : Fractal
    {


        public CircleFractal(Color[] colour, Graphics g, Pen p, int width, int heigth) : base(colour, g, p, width, heigth)
        {

        }

        public override void Draw(int iterations, int length, PointF[] points, double angle)
        {
            int x = (int)points[0].X;
            int y = (int)points[0].Y;
            P.Color = Gradient[Gradient.Length - iterations];
            G.DrawEllipse(P, x - length / 2, y - length / 2, length, length);
            if (iterations == 1)
            {
                P.Color = Gradient[0];
            }
            else
            {
                Draw(iterations - 1, length / 3, new PointF[] { new PointF(x, y) }, 0);
                Draw(iterations - 1, length / 3, new PointF[] { new PointF(x, (int)(y + length / 3F)) }, 0);
                Draw(iterations - 1, length / 3, new PointF[] { new PointF(x, (int)(y - length / 3F)) }, 0);
                Draw(iterations - 1, length / 3, new PointF[]{new PointF
                    (x + (int) (length / 3 * Math.Cos(Math.PI * 5.0 / 6.0)),
                        y + (int) (length / 3 * Math.Sin(Math.PI * 5.0 / 6.0)))
                }, 0);
                Draw(iterations - 1, length / 3, new PointF[] { new PointF(x + (int)(length / 3 * Math.Cos(Math.PI * 7.0 / 6.0)), y + (int)(length / 3 * Math.Sin(Math.PI * 7.0 / 6.0))) }, 0);
                Draw(iterations - 1, length / 3, new PointF[] { new PointF(x + (int)(length / 3 * Math.Cos(Math.PI * 1.0 / 6.0)), y + (int)(length / 3 * Math.Sin(Math.PI * 1.0 / 6.0))) }, 0);
                Draw(iterations - 1, length / 3, new PointF[] { new PointF(x + (int)(length / 3 * Math.Cos(Math.PI * 11.0 / 6.0)), y + (int)(length / 3 * Math.Sin(Math.PI * 11.0 / 6.0))) }, 0);
            }
        }
    }
}
