# Egyetemi feladatok

Hét önálló C# konzolprojekt egy közös GitHub-tárolóban. A tároló korábbi neve és az első projekt Git-előzménye megmaradt.

| Mappa | Téma |
| --- | --- |
| `Egyetem.Feladat.1` | Alapműveletek, típuskonverzió és elágazások |
| `Egyetemi.feladat.2` | Tömbök, véletlen számok és összegzés |
| `Egyetemi.feladat.3` | Szövegfájl olvasása és bővítése |
| `Egyetemi.feladat.4` | Eredmények feldolgozása és osztályzatok |
| `Egyetemi_feladat_loverseny` | Háromszögek kerülete, területe és generálása |
| `Egyetemi_feladat_Objektum_Orai` | Hallgatók, öröklődés és pontszámok |
| `Egyetemi_feladat_objekt_Levelezo` | Levelező hallgató osztályának megkezdett feladata |

## Megnyitás

Nyisd meg az `Egyetemi-feladatok.slnx` fájlt egy SLNX-formátumot támogató Visual Studióban. Minden projekt külön indítható: a kívánt projekten válaszd a **Set as Startup Project** lehetőséget. A `.csproj` fájlok külön is megnyithatók.

A projektek .NET Framework 4.7.2-t céloznak; a fordításhoz a megfelelő fejlesztői csomag szükséges.

## Jelenlegi állapot

A feltöltés az eredeti helyi forráskódot őrzi meg. A hét projektből hat sikeresen lefordult MSBuilddel Debug konfigurációban.

Az `Egyetemi_feladat_objekt_Levelezo` projekt jelenleg CS1729 hibával fordul: a `Distance_learner` osztály kétparaméteres ősosztály-konstruktort hív, de nincs megadva hozzá ilyen ősosztály. Ez a helyi forrásban is meglévő, befejezetlen rész.

A fájlkezelési feladatok futtatásához a munkakönyvtárban bemeneti fájl szükséges:

- `Egyetemi.feladat.3`: `szamok.txt`.
- `Egyetemi.feladat.4`: `eredmenyek.txt`, soronként `név;pontszám` formátumban.
- `Egyetemi_feladat_Objektum_Orai`: `eredmenyek.txt`, soronként `név;pontszám;képzési forma` formátumban.

A `bin`, `obj` és `.vs` mappák, valamint a bennük tárolt futási és generált fájlok nem részei a tárolónak.
