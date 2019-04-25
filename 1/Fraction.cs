using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Fraction
    {
        int num; //.. числитель
        int den; //.. знаменатель

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public int Den
        {
            get
            {
                return den;
            }
            set
            {
                if (value == 0) throw new DivideByZeroException();
                if (value <0)
                {
                    value = -value;
                    num = -num;
                }
                den = value;
            }
        }

        private int NOD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return NOD(b, a % b);
            }
        }

        public Fraction(int n, int d)
        { // Конструктор
            if (n >= 0 && d > 0)
            {
                num = n;
                den = d;
                return;
            }
            if (n >= 0 && d < 0)
            {
                num = -n;
                den = -d;
                return;
            }
            if (n <= 0 && d > 0)
            {
                num = n;
                den = d;
                return;
            }
            if (n <= 0 && d < 0)
            {
                num = -n;
                den = -d;
                return;
            }
            Console.WriteLine("Нулевой знаменатель: {0}/{1}", n, d);
            return;
        }

        static public Fraction operator -(Fraction f)
        {
            return new Fraction(-f.num, f.den);
        }

        static public bool operator <(Fraction f1, Fraction f2)
        {
            if (f1.num * f2.den < f1.den * f2.num) return true;
            else return false;
        }

        static public bool operator >(Fraction f1, Fraction f2)
        {
            if (f1.num * f2.den > f1.den * f2.num) return true;
            else return false;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", num, den);
        }

        public Fraction Add(Fraction fraction)
        {
            int num_ans = num * fraction.Den + fraction.Num * den;
            int den_ans = den * fraction.Den;
            int nod = NOD(num_ans, den_ans);
            num_ans /= nod;
            den_ans /= nod;
            return new Fraction(num_ans, den_ans);
        }

        public static Fraction operator +(Fraction fraction, Fraction fraction1)
        {
            return fraction.Add(fraction1);
        }

        public Fraction Removal(Fraction fraction)
        {
            int num_ans = num * fraction.Den - fraction.Num * den;
            int den_ans = den * fraction.Den;
            int nod = NOD(Math.Abs(num_ans), den_ans);
            num_ans /= nod;
            den_ans /= nod;
            return new Fraction(num_ans, den_ans);
        }

        public static Fraction operator -(Fraction fraction, Fraction fraction1)
        {
            return fraction.Removal(fraction1);
        }

        public Fraction Multiplications(Fraction fraction)
        {
            int den_ans = den * fraction.Den;
            int num_ans = num * fraction.Num;
            int nod = NOD(Math.Abs(num_ans), den_ans);
            num_ans /= nod;
            den_ans /= nod;
            return new Fraction(num_ans, den_ans);
        }

        public static Fraction operator *(Fraction fraction, Fraction fraction1)
        {
            return fraction.Multiplications(fraction1);
        }

        public Fraction Div(Fraction fraction)
        {
            if (fraction.Num == 0) throw new DivideByZeroException();
            return this.Multiplications(new Fraction(fraction.Den, fraction.Num));
        }

        public static Fraction operator /(Fraction fraction, Fraction fraction1)
        {
            return fraction.Div(fraction1);
        }

        public Fraction PlusPlus()
        {
            num += den;
            return this;
        }

        public static Fraction operator ++(Fraction fraction)
        {
            return fraction.PlusPlus();
        }

        public Fraction MinusMinus()
        {
            num -= den;
            return this;
        }

        public static Fraction operator --(Fraction fraction)
        {
            return fraction.MinusMinus();
        }

        public double Convert()
        {
            return (num * 1.0) / den;
        }
    }
}
