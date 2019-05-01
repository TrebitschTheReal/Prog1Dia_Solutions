using System;
using System.IO;

namespace StringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringmaker = new CreateStrings();
            int cnt = 0;

            do
            {
                cnt++;
                string nameOfTheTxt = stringmaker.CreateRandomName();
                var sw = new StreamWriter(@"E:\maszkolgatunk\" + nameOfTheTxt);
                sw.WriteLine("A nyuszi az jó!");
                sw.Close();
            } while (cnt != 20);
        }
    }
}
