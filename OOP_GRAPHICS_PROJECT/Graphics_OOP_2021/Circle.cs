using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graphics_OOP_2021
{
    class Circle : Figure
    {
        //int x;
        //int y; //class rectangle x y width height 
        int r;
        Pen bkPen = new Pen(Color.Black);
        public Circle(int x, int y, int rad) : base(x, y)
        {
            this.r = rad;
        }
        public int R
        {
            get
            {
                if (r <= 0)
                {
                    return r * (-1);
                }
                else
                {
                    return r;
                }
            }
            set
            {
                r = value;
            }
        }
        public override void Draw(Graphics graphics/*, int x, int y*/)
        {
            graphics.DrawEllipse(bkPen, X, Y, r, r);
        }
        public override bool Property(int x, int y)
        {
            double D = Math.Sqrt(Math.Pow(X + r - x, 2) + Math.Pow(Y - r - y, 2));
            return D <= r;
        }
    }
}
