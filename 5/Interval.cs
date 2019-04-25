using System;

namespace _5
{
    class Interval
    {
        double a, b;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
                if (a > b)
                {
                    a = b;
                    b = value;
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                if (a > b)
                {
                    b = a;
                    a = value;
                }
            }
        }

        public Interval (double A, double B)
        {
            if (A > B) 
            {
                b = A;
                a = B;
            }
            else
            {
                a = A;
                b = B;
            }
        }

        public Interval(Interval interval)
        {
            a = interval.A;
            b = interval.B;
        }

        public Interval Add(Interval interval)
        {
            return new Interval(a + interval.A, b + interval.B);
        }

        public double Length()
        {
            return b - a;
        }

        static public Interval operator +(Interval interval_1, Interval interval_2)
        {
            return interval_1.Add(interval_2);
        }

        public Interval Removal(Interval interval)
        {
            return new Interval(a - interval.A, b - interval.B);
        }

        static public Interval operator -(Interval interval_1, Interval interval_2)
        {
            return interval_1.Removal(interval_2);
        }

        public Interval Multiplications(Interval interval)
        {
            return new Interval(Math.Min(Math.Min(a * interval.A, a * interval.B), Math.Min(b * interval.A, b * interval.B)),
                Math.Max(Math.Max(a * interval.A, a * interval.B), Math.Max(b * interval.A, b * interval.B)));
        }

        static public Interval operator *(Interval interval_1, Interval interval_2)
        {
            return interval_1.Multiplications(interval_2);
        }

        public Interval Div(Interval interval)
        {
            if (interval.A <=0 && interval.B >= 0) throw new DivideByZeroException();
            return new Interval(Math.Min(Math.Min(a / interval.A, a / interval.B), Math.Min(b / interval.A, b / interval.B)),
                Math.Max(Math.Max(a / interval.A, a / interval.B), Math.Max(b / interval.A, b / interval.B)));
        }

        static public Interval operator /(Interval interval_1, Interval interval_2)
        {
            return interval_1.Div(interval_2);
        }

        public override string ToString()
        {
            return $"[{a}, {b}]";
        }
    }
}
