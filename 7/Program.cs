using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(10, 15);
            Console.WriteLine(money.TransferCost(5));
            Console.ReadKey();
        }
    }
}
