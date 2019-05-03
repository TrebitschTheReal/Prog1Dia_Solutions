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

            Console.WriteLine(txtreader.FullText);
            Console.WriteLine(txtreader.NumberOfLines);
            Console.WriteLine(txtreader.NumberOfCharacters);

            Console.ReadKey();
        }
    }
}
