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

            Console.ReadKey();
        }
    }
}
