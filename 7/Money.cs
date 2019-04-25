using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Money
    {
        int rub, cop;

        public int Rub
        {
            get
            {
                return rub;
            }
            set
            {
                rub = value;
            }
        }

        public int Cop
        {
            get
            {
                return cop;
            }
            set
            {
                cop = value;
            }
        }

        public Money(int Rub, int Cop)
        {
            rub = Rub;
            rub += Cop / 100;
            cop = Cop % 100;
            if (rub * cop < 0) 
            {
                if (rub > 0)
                {
                    --rub;
                    cop += 100;
                }
                else
                {
                    ++rub;
                    cop -= 100;
                }
            }
        }

        public Money(Money money)
        {
            rub = money.Rub;
            cop = money.Cop;
        }

        public Money TransferCost(double procent)
        {
            int ans = (int)((rub * 100 + cop) * (100 + procent) / 100);
            return new Money(ans / 100, ans % 100);
        }

        public Money Add(Money money)
        {
            return new Money(rub + money.Rub, cop + money.Cop);
        }

        static public Money operator +(Money money, Money money1)
        {
            return money.Add(money1);
        }

        public Money Removal(Money money)
        {
            return new Money(rub - money.Rub, cop - money.Cop);
        }

        static public Money operator -(Money money, Money money1)
        {
            return money.Removal(money1);
        }

        public Money Div(double n)
        {
            if (n == 0) throw new DivideByZeroException();
            int ans = (int)((rub * 100 + cop)/n);
            return new Money(ans / 100, ans % 100);
        }

        static public Money operator /(Money money, double n)
        {
            return money.Div(n);
        }

        static public Money operator /(double n, Money money)
        {
            return money.Div(n);
        }

        public Money Multiplications(double n)
        {
            int ans = (int)((rub * 100 + cop) * n);
            return new Money(ans / 100, ans % 100);
        }

        static public Money operator *(Money money, double n)
        {
            return money.Multiplications(n);
        }

        static public Money operator *(double n, Money money)
        {
            return money.Multiplications(n);
        }

        public override string ToString()
        {
            return $"{rub} рублей {cop} копеек";
        }
    }
}
