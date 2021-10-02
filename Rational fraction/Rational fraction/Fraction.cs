using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_fraction
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            set { numerator = value; }
            get { return numerator; }
        }
        public int Denominator
        {
            set
            //{
            //    this.denominator = value;
            //    if (value == 0)

            //        throw new Exception("Заменатель не может быть равен 0!");

            //    else
            { this.denominator = value; }
            
            get { return denominator; }
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        private Fraction Sum(Fraction f2)
        {
            return new Fraction(f2.Numerator * this.Denominator + f2.Denominator * this.Numerator, f2.Denominator * this.Denominator);
        }
        public static Fraction sum_static(Fraction fr1, Fraction fr2)
        {
            return fr1.Sum(fr2);
        }

        private Fraction Multiply(Fraction f2)
        {
            return new Fraction(f2.Numerator * this.Numerator, f2.Denominator * this.Denominator);

        }

        private Fraction Subtract(Fraction f2)
        {
            return new Fraction(f2.Numerator * this.Denominator - f2.Denominator * this.Numerator, f2.Denominator * this.Denominator);
        }
        private Fraction Divide(Fraction f2)
        {
            return new Fraction(f2.Numerator * this.Denominator, f2.Denominator * this.Numerator);
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2) // перегрузка операторов
        {
            return fr1.Sum(fr2);
        }
        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            return fr2.Subtract(fr1);
        }
        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            return fr2.Divide(fr1);
        }
        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            return fr1.Multiply(fr2);
        }
            public static Fraction operator ++(Fraction fr1)
            {
                return fr1++;
            }
            public static Fraction operator --(Fraction fr1)
            {
                return fr1--;
            }

        public override string ToString()
        {
            string str = (this.Numerator + "/" + this.Denominator);
            return str;
        }
    }
}
