using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graphics_OOP_2021
{
    public partial class Form1 : Form
    {
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
        }
        List<Figure> figures = new List<Figure>();
        int x_stretch = 0;
        int y_stretch = 0;
        int _x = 0;
        int _y = 0;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x_stretch = e.X;
            y_stretch = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;

            if (rb_rect.Checked)
            {
                int rect_width = Math.Abs(_x - x_stretch);
                int rect_height = Math.Abs(_y - y_stretch);
                Rectangle rect = new Rectangle(x_stretch, y_stretch, rect_height, rect_width);
                rect.Draw(graphics);
                figures.Add(rect);
            }
            if (rb_circle.Checked)
            {
                double rad = Math.Sqrt(Math.Pow((x_stretch - _x), 2) + Math.Pow((y_stretch - _y), 2)); // вектор
                Circle circle = new Circle(x_stretch, y_stretch, (int)rad);
                circle.Draw(graphics);
                figures.Add(circle);

            }
            if (rb_cart.Checked)
            {
                int rect_width = Math.Abs(_x - x_stretch);
                int rect_height = Math.Abs(_y - y_stretch);
                Cart cart = new Cart(x_stretch, y_stretch, rect_height, rect_width);
                cart.Draw(graphics);
                figures.Add(cart);
            }
            if (rb_sandcart.Checked)
            {
                int rect_width = Math.Abs(_x - x_stretch);
                int rect_height = Math.Abs(_y - y_stretch);
                SandCart sandCart = new SandCart(x_stretch, y_stretch, rect_height, rect_width);
                sandCart.Draw(graphics);
                figures.Add(sandCart);
            }
            if (rb_coalcart.Checked)
            {
                int rect_width = Math.Abs(_x - x_stretch);
                int rect_height = Math.Abs(_y - y_stretch);
                CoalCart coalCart = new CoalCart(x_stretch, y_stretch, rect_height, rect_width);
                coalCart.Draw(graphics);
                figures.Add(coalCart);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void button_createtrain_Click(object sender, EventArgs e)
        { 
            int x_last = panel1.Width;
            int y_last = panel1.Height / 2;
            int quantity = Convert.ToInt32(textBox_vagonquantity.Text);
            Train train = new Train(_x, _y, (y_last / quantity) / 2, x_last / quantity, quantity);
            train.Draw(graphics);
        }
    }
}
