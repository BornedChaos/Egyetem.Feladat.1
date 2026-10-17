using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Egyetemi_feladat_loverseny
{
    internal class Haromszog
    {
        double a, b, c;
        public Haromszog(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Kerulet()
        {
            return a + b + c;
        }
        public double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public Haromszog()
        {
            var rnd = new Random();
            do
            {
                a = rnd.Next(0, 11);
                b = rnd.Next(0, 11);
                c = rnd.Next(0, 11);
            }
            while (!Szerkesztheto(a, b, c));
        }
        private bool Szerkesztheto(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}