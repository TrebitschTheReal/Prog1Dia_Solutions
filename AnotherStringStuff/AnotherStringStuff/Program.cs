using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnotherStringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var txtreader = new TxtReader();

            Console.WriteLine("Sorok száma: {0}", txtreader.NumberOfLines);
            Console.WriteLine("Karakterek száma: {0}", txtreader.NumberOfCharacters);
            Console.WriteLine("Betűk száma: {0}", txtreader.NumberOfLetters);
            Console.WriteLine("Számok száma: {0}", txtreader.NumberOfNumbers);
            Console.WriteLine("Speciális karakterek száma: {0}", txtreader.NumberOfSpecialCharacters);
            Console.WriteLine("Szavak száma: {0}", txtreader.WordsInText);

            Console.ReadKey();
        }
    }
}


/*
 * Szó: az a karaktersorozat, ami egy space vagy egy speciális karakter között áll, vagy két space között áll
 * szavakat egy string tömbbe, annyi elemű legyen a tömb ahány szó van. minden egyes elem legyen egyenlő egy szóval. amelyik lengthje a leghosszabb
 * (maximumkiválasztás) az a leghosszabb szó
 * 
 * leggyakoribb szó ugyan így
 */