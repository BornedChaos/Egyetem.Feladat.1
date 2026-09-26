using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyetem.Feladat._1
{
    internal class Program
    {
        static int osszeg(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Add meg a neved: ");
            string s = Console.ReadLine();
            Console.WriteLine("Szia, " + s + "!");
            Console.WriteLine(s.Remove(1, 2));
            Console.WriteLine(s.Insert(2, "*"));*/
            Console.WriteLine("Add meg az első számot: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a második számot: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Az összeg: " + osszeg(x, y));
            double hanyados = (double)x / y; //típuskonverzió a pontos osztás érdekében
            Console.WriteLine("Az osztás eredménye: " + hanyados);
            if (x < y)
            {
                Console.WriteLine("Az első szám kisebb, mint a második.");
            }
            else if (x == y)
            {
                Console.WriteLine("A két szám egyenlő.");
            }
            else
            {
                Console.WriteLine("Az első szám nagyobb, mint a második.");
            }
        }
        
    }
}