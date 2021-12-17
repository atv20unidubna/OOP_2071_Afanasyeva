using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_OOP_2021
{
    abstract class Figure
    {
        private int x; // координаты фигуры
        private int y;

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics graphics);

        public abstract bool Property(int x, int y);
        

    }
}
