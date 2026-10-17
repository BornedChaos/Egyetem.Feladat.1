using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Egyetemi_feladat_loverseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Haromszog h1 = new Haromszog(2, 3, 4);
            Console.WriteLine("Kerület: {0}", h1.Kerulet());
            Console.WriteLine("Terület: {0}", h1.Terulet());
            Haromszog[] tomb = new Haromszog[3];
            for (int i = 0; i < 3; i++)
            {
                tomb[i] = new Haromszog();
            }
        }
    }
}