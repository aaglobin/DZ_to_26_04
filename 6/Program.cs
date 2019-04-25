using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Polynmial2 a = new Polynmial2(ran.Next(-100, 100), ran.Next(-100, 100), ran.Next(-100, 100));
            Polynmial2 b = new Polynmial2(ran.Next(-100, 100), ran.Next(-100, 100), ran.Next(-100, 100));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Polynmial2 c = new Polynmial2(a % b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
