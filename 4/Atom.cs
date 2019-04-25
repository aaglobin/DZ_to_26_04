using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Atom
    {
        int x, y, z, count;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public Atom(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
            count = 0;
        }

        public static bool operator <(Atom a, Atom b)
        {
            return a.Count < b.Count;
        }

        public static bool operator >(Atom a, Atom b)
        {
            return a.Count > b.Count;
        }
        
        public override string ToString()
        {
            return $"x = {x}, y = {y}, z = {z}, count = {count}";
        }
    }
}
