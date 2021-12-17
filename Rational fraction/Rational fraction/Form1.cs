using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rational_fraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Fraction res;
        // спросить про то, нужно ли переделывать переопределение для выделения целой части 
        // спросить про НОД -- для чего он делается? для дроби или для каких-то рнд чисел? 
        // метод Is_den_corr нигде не вызывается из-за нерабочей схемы выбрасывания исключения (?)
        // что не так с исключением? 
        private void Is_den_corr(Fraction f1, Fraction f2) // метод, проверяющий корректность знаменателя (ненулевой)
        {
            try
            {
                f1.Denominator = Convert.ToInt32(textBox_den1.Text);
                f2.Denominator = Convert.ToInt32(textBox_den2.Text);// проверка знаменатель не равен 0, выбрасывание искл
            }
            catch (Exception ex)
            {
                textBox_result.Text = ex.Message;
            }
        }
        //private Fraction read_values(Fraction f1, Fraction f2)
        //{

        //    return (f1, f2);
        //}

        private void button_plus_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            Fraction fr1 = new Fraction(Convert.ToInt32(textBox_num1.Text), Convert.ToInt32(textBox_den1.Text));
            Fraction fr2 = new Fraction(Convert.ToInt32(textBox_num2.Text), Convert.ToInt32(textBox_den2.Text));
             res = new Fraction(0, 0);
            Fraction res1 = new Fraction(0, 0);
            //is_den_corr(fr1, fr2);
            res = fr1 + fr2;
            textBox_result.Text = res.ToString();
            res1 = res;
            textBox_cut.Text = Convert.ToString(Cut_the_fraction(res1));
            //textBox_NOD.Text = Convert.ToString(NOD(res));
            //ВНЕДРИТЬ метод, проверяющий корректность знаменателя 
            //textBox_result.Text = Convert.ToString(f1 + f2);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            Fraction fr1 = new Fraction(Convert.ToInt32(textBox_num1.Text), Convert.ToInt32(textBox_den1.Text));
            Fraction fr2 = new Fraction(Convert.ToInt32(textBox_num2.Text), Convert.ToInt32(textBox_den2.Text));
             res = new Fraction(0, 0);
            Fraction res1 = new Fraction(0, 0);
            //is_den_corr(fr1, fr2);
            res = fr1 - fr2;
            textBox_result.Text = res.ToString();
            res1 = res;
            textBox_cut.Text = Convert.ToString(Cut_the_fraction(res1));
            //textBox_NOD.Text = Convert.ToString(NOD(res));
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            Fraction fr1 = new Fraction(Convert.ToInt32(textBox_num1.Text), Convert.ToInt32(textBox_den1.Text));
            Fraction fr2 = new Fraction(Convert.ToInt32(textBox_num2.Text), Convert.ToInt32(textBox_den2.Text));
             res = new Fraction(0, 0);
            Fraction res1 = new Fraction(0, 0);
            //is_den_corr(fr1, fr2);
            res = fr1 / fr2;
            textBox_result.Text = res.ToString();
            res1 = res;
            textBox_cut.Text = Convert.ToString(Cut_the_fraction(res1));
            //textBox_NOD.Text = Convert.ToString(NOD(res));
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            Fraction fr1 = new Fraction(Convert.ToInt32(textBox_num1.Text), Convert.ToInt32(textBox_den1.Text));
            Fraction fr2 = new Fraction(Convert.ToInt32(textBox_num2.Text), Convert.ToInt32(textBox_den2.Text));
            res = new Fraction(0, 0);
            Fraction res1 = new Fraction(0,0);
            //is_den_corr(fr1, fr2);
            res = fr1 * fr2;
            textBox_result.Text = res.ToString();
            res1 = res;
            textBox_cut.Text = Convert.ToString(Cut_the_fraction(res1));
            //textBox_NOD.Text = Convert.ToString(NOD(res));
        }
        private Fraction Cut_the_fraction(Fraction fr1)
        {
            // метод проверка делимости числителя и знаменателя на одно и то же число 
            //если делится — выводится результат деления

            if (fr1.Denominator < fr1.Numerator)
            {
                for (int i = Convert.ToInt32(Math.Sqrt(fr1.Numerator)) + 1; i >= 2; i--)
                {
                    if (fr1.Numerator % i == 0 && fr1.Denominator % i == 0)
                    {
                        fr1.Numerator = fr1.Numerator / i;
                        fr1.Denominator = fr1.Denominator / i;
                    }

                }

            }
            if (fr1.Denominator > fr1.Numerator)
            {
                for (int i = Convert.ToInt32(Math.Sqrt(fr1.Denominator)) + 1; i >= 2; i--)
                {
                    if (fr1.Numerator % i == 0 && fr1.Denominator % i == 0)
                    {
                        fr1.Numerator = fr1.Numerator / i;
                        fr1.Denominator = fr1.Denominator / i;
                    }

                }

            }
            return fr1;
        }
        private int NOD(Fraction f1) // это плохой метод, он все ломает 
        {
            int _n = f1.Numerator;
            int _d = f1.Denominator;
            if (_n == 0)
            {
                return _d;
            }
            while (_n != 0)
            {
                if (_n > _d)
                {
                    _n -= _d;
                }
                else
                {
                    _d -= _n;
                }
            }
            int nod = _n;
            return _n;
        }

    }
}
