using System;
using System.Collections.Generic;
using System.IO; //csomag importálása a programba, ami lehetővé teszi a fájlkezelést
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyetemi.feladat._3
{
    internal class Program
    {
        static void Listazas(string[] tomb) //függvény deklarálása, ami a szövegfájl sorait listázza
        {
            for (int i = 0; i < tomb.Length; i++) //ciklus deklarálása, ami a szövegfájl sorait listázza
            {
                Console.WriteLine("A " + i + ". sor: " + tomb[i]); //sorszám és a szövegfájl sorainak kiírása a konzolra
            }
        }
        static void Hozzair(string sor) //függvény deklarálása, ami egy szövegfájl sorát hozzáfűzi a fájlhoz
        {
            //File.AppendAllText("szamok.txt", sor + Environment.NewLine); //szövegfájl megnyitása, írása, majd bezárása egy parancsban, ha nincs ilyen fájl, akkor létrehozza, egy-egy értékhez jó
            StreamWriter t = new StreamWriter("szamok.txt", true); //szövegfájl deklarálása, egyszerre több érték beírására alkalmasabb és gyorsabb
            t.WriteLine(sor); //szövegfájl írása
            t.Close(); //szövegfájl bezárása
        }
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("szamok.txt"); //szövegfájl beolvasása
            Listazas(sorok); //szövegfájl sorainak listázása
            Hozzair("Ez egy új sor."); //szövegfájlhoz új sor hozzáfűzése
        }
    }
}
