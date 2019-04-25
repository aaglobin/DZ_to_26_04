using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Interval a = new Interval(ran.Next(), ran.NextDouble());
            Interval b = new Interval(ran.NextDouble(), ran.Next());
            Interval c = new Interval(a * b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
