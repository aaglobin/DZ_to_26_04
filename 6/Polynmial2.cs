using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Polynmial2
    {
        double a, b, c;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
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
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public Polynmial2(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public Polynmial2(Polynmial2 polynmial)
        {
            a = polynmial.A;
            b = polynmial.B;
            c = polynmial.C;
        }

        public double Value(double x)
        {
            return a * x * x + b * x + c;
        }

        public Polynmial2 Add(Polynmial2 polynmial)
        {
            return new Polynmial2(a + polynmial.A, b + polynmial.B, c + polynmial.C);
        }

        public static Polynmial2 operator +(Polynmial2 polynmial, Polynmial2 polynmial2)
        {
            return polynmial.Add(polynmial2);
        }

        public Polynmial2 Removal(Polynmial2 polynmial)
        {
            return new Polynmial2(a - polynmial.A, b - polynmial.B, c - polynmial.C);
        }

        public static Polynmial2 operator -(Polynmial2 polynmial, Polynmial2 polynmial2)
        {
            return polynmial.Removal(polynmial2);
        }
        
        public Polynmial2 Multiplications(double k)
        {
            return new Polynmial2(a * k, b * k, c * k);
        }

        public static Polynmial2 operator *(double k, Polynmial2 polynmial)
        {
            return polynmial.Multiplications(k);
        }

        public static Polynmial2 operator *(Polynmial2 polynmial, double k)
        {
            return polynmial.Multiplications(k);
        }

        public Polynmial2 Div(double k)
        {
            if (k == 0) throw new DivideByZeroException();
            return new Polynmial2(a / k, b / k, c / k);
        }

        public static Polynmial2 operator /(double k, Polynmial2 polynmial)
        {
            return polynmial.Div(k);
        }

        public static Polynmial2 operator /(Polynmial2 polynmial, double k)
        {
            return polynmial.Div(k);
        }

        public Polynmial2 Mod(Polynmial2 polynmial)
        {
            if (a == 0 && polynmial.A != 0)
            {
                return new Polynmial2(this);
            }
            else if (a != 0 && polynmial.A != 0)
            {
                return new Polynmial2(0, b - (polynmial.B * a) / polynmial.A, c - (polynmial.C * a) / polynmial.A);
            }
            else if (a != 0 && polynmial.A == 0)
            {
                if(polynmial.B != 0)
                {
                    return new Polynmial2(0, 0, c - ((b - (polynmial.C * a) / polynmial.B) * polynmial.C) / polynmial.B);
                }
                else
                {
                    if (polynmial.C == 0) throw new DivideByZeroException();
                    return new Polynmial2(0, 0, 0);
                }
            }
            else // a == 0 && polynomal.A == 0
            {
                if(b == 0 && polynmial.B == 0)
                {
                    if (polynmial.C == 0) throw new DivideByZeroException();
                    return new Polynmial2(0, 0, 0);
                }
                else if (b != 0 && polynmial.B == 0)
                {
                    if (polynmial.C == 0) throw new DivideByZeroException();
                    return new Polynmial2(0, 0, 0);
                }
                else if(b == 0 && polynmial.B != 0)
                {
                    return new Polynmial2(this);
                }
                else // b != 0 && polynomal.B != 0
                {
                    return new Polynmial2(0, 0, c - (b * polynmial.C) / polynmial.B);
                }
            }
        }

        public static Polynmial2 operator %(Polynmial2 polynmial, Polynmial2 polynmial2)
        {
            return polynmial.Mod(polynmial2);
        }

        public override string ToString()
        {
            if (a == 0 && b == 0)
            {
                return $"{c}";
            }
            else if (a == 0 && b != 0)
            {
                return $"{b} * x + {c}";
            }
            else
            {
                return $"{a} * x * x + {b} * x + {c}";
            }
        }
    }
}
