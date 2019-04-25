using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int x_max = ran.Next(1, 100), y_max = ran.Next(1, 100), z_max = ran.Next(1, 100);
            Atom[,,] lattice = new Atom[x_max, y_max, z_max];
            int n = ran.Next(0, x_max * y_max * z_max);
            for (int i = 0; i < n; i++)
            {
                Atom atom = new Atom(ran.Next(0, x_max), ran.Next(0, y_max), ran.Next(0, z_max));
                while(lattice[atom.X, atom.Y, atom.Z] != null)
                {
                    atom.X = ran.Next(0, x_max);
                    atom.Y = ran.Next(0, y_max);
                    atom.Z = ran.Next(0, z_max);
                    atom.Count = atom.Count + 1;
                }
                lattice[atom.X, atom.Y, atom.Z] = atom;
            }
        }
    }
}
