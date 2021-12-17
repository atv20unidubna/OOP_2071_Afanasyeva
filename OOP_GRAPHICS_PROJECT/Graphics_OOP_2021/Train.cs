using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_OOP_2021
{
    class Train : Figure
    {
        int heigth;
        int width;
        int vagQuantity;
        int margin = 5;
        public Train(int x, int y, int heigth, int width, int vagQuantity) : base(x, y)
        {
            this.heigth = heigth;
            this.width = width;
            this.vagQuantity = vagQuantity;
        }
        public override void Draw(Graphics graphics)
        {
            int x0 = 2;
            int y0 = 120;
            Cart[] cart_arr = new Cart[vagQuantity];
                for (int i = 0; i < vagQuantity; i++)
                {
                    cart_arr[i] = new Cart(x0, y0, heigth, width);
                    cart_arr[i].Draw(graphics);
                    x0 += width + margin;
                }
            return;
        }
        public override bool Property(int x, int y)
        {
            return false;
        }

    }
}
