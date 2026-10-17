using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyetemi.feladat._2
{
    internal class Program
    {
        static int[] Feltolt(int n) //függvény deklarálása, ami egy int típusú paramétert vár és egy int típusú tömböt ad vissza
        {
            int[] tomb = new int[n]; //számtömb deklarálás
            Random rnd = new Random(); //random számérték generálása
            for (int i = 0; i < n; i++) //ciklus deklarálása, ami a tömb feltöltéséért felelős
            {
                tomb[i] = rnd.Next(1, 101); //random számérték beillesztése a tömbbe 1 és 100 közötti értékekkel
            }
            return tomb;
        }
        static void Listazas(int[] tomb) //függvény deklarálása, ami a tömb elemeit listázza
        {
            for (int i = 0; i < tomb.Length; i++) //ciklus deklarálása, ami a tömb elemeit listázza
            {
                Console.WriteLine("A tömb hossza: " + tomb.Length); //tömb hosszának kiírása a konzolra
                Console.WriteLine("A " + i + ". elem: " + tomb[i]); //sorszám és a tömb elemeinek kiírása a konzolra
            }
        }
        static void Main(string[] args)
        {
            int[] A = Feltolt(5); //tömb feltöltése 5 random számértékkel
            int[] B = Feltolt(123);
            Listazas(A); //tömb elemeinek listázása
            Listazas(B);
            Console.WriteLine("Az 'A' tömb elemeinek összege: " + Osszeg(A)); //tömb elemeinek összegzése
            Console.WriteLine("A 'B' tömb elemeinek összege: " + Osszeg(B));
        }
        static int Osszeg(int[] tomb) //függvény deklarálása, ami a tömb elemeinek összegét adja vissza
        {
            int osszeg = 0; //összeg változó deklarálása
            for (int i = 0; i < tomb.Length; i++) //ciklus deklarálása, ami a tömb elemeit összegzi
            {
                osszeg += tomb[i]; //összegzés a tömb elemeivel
            }
            return osszeg; //összeg visszaadása
        }
    }
}
