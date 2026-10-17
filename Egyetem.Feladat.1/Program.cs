using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //csomagok importálása a programba, ami lehetővé teszi a különböző osztályok és metódusok használatát

namespace Egyetem.Feladat._1 //névtér deklarációja, ami a programban található osztályokat és metódusokat csoportosítja
{
    internal class Program //osztály deklarációja, ami a program fő logikáját tartalmazza
    {
        static int osszeg(int a, int b) //függvény deklarációja, ami két int típusú paramétert vár és egy int típusú értéket ad vissza
        {
            /*int eredmeny = a + b;
            return eredmeny;*/
            return a + b; //függvény érték visszaadása
        }
        static void Main(string[] args) //program belépési pontja, ami a program futtatásakor elsőként kerül végrehajtásra
        {
            /*Console.WriteLine("Add meg a neved: "); //kiírás a konzolra
            string s = Console.ReadLine(); //értékek beolvasása a konzolról (felhasználótól)
            Console.WriteLine("Szia, " + s + "!");
            Console.WriteLine(s.Remove(1, 2));
            Console.WriteLine(s.Insert(2, "*"));*/
            Console.WriteLine("Add meg az első számot: ");
            // int x = int.Parse(Console.ReadLine()); //konvertálás stringből int típusra deklarációval
            int x = Convert.ToInt32(Console.ReadLine()); //konvertálás stringből int típusra másként deklarációval
            Console.WriteLine("Add meg a második számot: ");
            //int y = int.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Az összeg: " + osszeg(x, y));
            double hanyados = (double)x / y; //típuskonverzió a pontos osztás érdekében [végeredmény tizedes érték lesz] deklarációval
            Console.WriteLine("Az osztás eredménye: " + hanyados);
            if (x < y) //feltételes elágazás
            {
                Console.WriteLine("Az első szám kisebb, mint a második.");
            }
            else if (x == y) //feltételes elágazás, akkor fut ide, ha az előző feltétel nem teljesül és a jelenlegi feltétel teljesül
            {
                Console.WriteLine("A két szám egyenlő.");
            }
            else //feltétel mentes elágazás [ide fut be, ha az előző feltételek nem teljesülnek]
            {
                Console.WriteLine("Az első szám nagyobb, mint a második.");
            }
        }
        
    }
}