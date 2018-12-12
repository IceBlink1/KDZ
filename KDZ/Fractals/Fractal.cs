using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    public abstract class Fractal
    {
        
        private Color[] gradient;
        private Graphics g;
        private Pen p;
        private int width;
        private int heigth;
        
        public Color[] Gradient
        {
            get { return gradient; }
            set
            {
                gradient = new Color[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    gradient[i] = value[i];
                }
            }
        }
        public Graphics G
        {
            get { return g; }
            set { g = value; }
        }

        public Pen P
        {
            get { return p; }
            set { p = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }
        public Fractal() : this( new Color[] {Color.Black, Color.Black} , Graphics.FromImage(new Bitmap(0,0)), new Pen(Color.Black), 764,649)
        { }
        public Fractal(Color[] colour, Graphics g, Pen p, int width, int heigth)
        {
            Gradient = colour;
            G = g;
            P = p;
            Width = width;
            Heigth = heigth;
        }
        public abstract void Draw(int iterations, int length, PointF[] points, double angle);
    }

}
