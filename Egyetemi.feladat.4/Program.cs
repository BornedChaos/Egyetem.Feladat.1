using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Egyetemi.feladat._4
{
    internal class Program
    {
        static void Fajlir(string[] sorok, string fajlnev) //függvény deklarálása, ami egy szövegfájl sorát írja a fájlba
        {
            StreamWriter t = new StreamWriter(fajlnev, true); //szövegfájl deklarálása
            for (int i = 0; i < sorok.Length; i++)
            {
                t.WriteLine(sorok[i]); //szövegfájl megnyitása és írása, ha nincs ilyen fájl, akkor létrehozza
            }
            t.Close(); //szövegfájl bezárása
        }
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("eredmenyek.txt"); //szövegfájl beolvasása egy tömbbe, a sorok mentén
            string[] nevek = new string[sorok.Length];
            string[] pontszamok = new string[sorok.Length];
            for (int i = 0; i < sorok.Length; i++) //ciklus deklarálása, ami a szövegfájl sorait olvassa be
            {
                string[] soradatok = sorok[i].Split(';'); //szövegfájl sorainak feldarabolása a ';' karakter mentén
                nevek[i] = soradatok[0]; //szövegfájl sorainak első részének beillesztése a nevek tömbbe
                pontszamok[i] = soradatok[1]; //szövegfájl sorainak második részének beillesztése a pontszamok tömbbe
            }
            Fajlir(nevek, "nevek.txt"); //szövegfájl sorainak kiírása a nevek.txt fájlba
            Fajlir(pontszamok, "pontszamok.txt"); //szövegfájl sorainak kiírása a pontszamok.txt fájlba
            Console.WriteLine("A pontszámok közül hány darab elégtelen: " + ElegtelenDB(Array.ConvertAll(pontszamok, int.Parse))); //elégtelen eredmények db száma kiírása a konzolra, a pontszámok tömb elemeinek konvertálása int típusra
            Console.WriteLine("A pontszámok átlaga: " + Atlag(Array.ConvertAll(pontszamok, int.Parse))); //a pontszámok tömb elemeinek átlagának kiszámítása és kiírása a konzolra, a pontszámok tömb elemeinek konvertálása int típusra
            Ertekeles(pontszamok, nevek); //pontszámok és nevek tömbjeinek értékelése és kiírása a szövegfájlba
        }
        static int ElegtelenDB(int[] tomb)
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 50) //feltétel ellenőrzése, hogy a pontszám elégtelen-e
                {
                    //db = db + 1; elégtelen pontszámok db számlálása
                    db++; //elégtelen pontszámok db számlálása másképp
                }
            }
            return db;
        }
        static double Atlag(int[] tomb)
        {
            double osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                //osszeg = osszeg + tomb[i]; //tömb értékeinek összeadása
                osszeg += tomb[i]; //tömb értékeinek összeadása másképp
            }
            return osszeg / tomb.Length; //átlag kiszámítása a tömb elemeinek összegéből és a tömb hosszából
        }
        static void Ertekeles(string[] pontszamok, string[] nevek) //függvény deklarálása, ami a pontszámok és nevek tömbjeit értékeli és kiírja egy szövegfájlba
        {
            int[] pontok = Array.ConvertAll(pontszamok, int.Parse); //pontszámok tömb elemeinek konvertálása int típusra
            StreamWriter t = new StreamWriter("osztalyzat.txt", true); //szövegfájl deklarálása
            for (int i = 0; i < pontok.Length; i++) //ciklus deklarálása, ami a pontszámok tömb elemeit értékeli
            {
                if (pontok[i] < 50)
                {
                    t.WriteLine($"{nevek[i]} - {pontok[i]} pont - elégtelen"); //szövegfájl írása a nevek és pontszámok tömb elemeiből, ha a pontszám elégtelen
                }
                else if (pontok[i] < 65)
                {
                    t.WriteLine($"{nevek[i]} - {pontok[i]} pont - elégséges");
                }
                else if (pontok[i] < 80)
                {
                    t.WriteLine($"{nevek[i]} - {pontok[i]} pont - közepes");
                }
                else if (pontok[i] < 90)
                {
                    t.WriteLine($"{nevek[i]} - {pontok[i]} pont - jó");
                }
                else
                {
                    t.WriteLine($"{nevek[i]} - {pontok[i]} pont - jeles");
                }
            }
            t.Close();
        }
    }
}