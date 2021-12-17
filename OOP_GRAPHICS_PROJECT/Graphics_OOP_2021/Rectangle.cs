using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graphics_OOP_2021
{
    class Rectangle : Figure
    {
        protected int x;
        protected int y;
        protected int heigth;
        protected int width;

        Pen bkPen = new Pen(Color.Black);
        public virtual int Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                if (value <= 0)
                {
                    heigth = value * (-1);
                }
                else
                {
                    heigth = value;
                }

            }
        }
        public virtual int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    width = value * (-1);
                }
                else
                {
                    width = value;
                }

            }

        }
        
        public Rectangle(int x, int y, int height, int width) : base(x, y)
        {
            this.heigth = height;
            this.width = width;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(bkPen, X, Y, Width, Heigth);
        }
        public override bool Property(int x, int y)
        {
            return true;
        }

    }
}
