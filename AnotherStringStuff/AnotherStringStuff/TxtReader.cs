using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnotherStringStuff
{
    class TxtReader
    {
        private string fullText = "";
        private int numberOfLines = 0;
        private int numberOfLetters = 0;
        private int numberOfNumbers = 0;
        private int numberOfCharacters = 0;

        public TxtReader()
        {
            this.fullText = GenerateFullText();
            this.numberOfLines = LineCounter();
            this.numberOfLetters = LetterCounter();
            this.numberOfNumbers = NumberCounter();
        }

        private int LineCounter()
        {
            StreamReader sr = new StreamReader(@"E:\maszkolgatunk\rimworld.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                numberOfLines++;
            }
            numberOCharacters = fullText.Length;
            sr.Close();
            return numberOfLines;
        }
        private int CharacterCounter()
        {
            StreamReader sr = new StreamReader(@"E:\maszkolgatunk\rimworld.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                numberOfCharacters = fullText.Length;
            }
            sr.Close();
            return numberOfCharacters;

        }
        private string GenerateFullText()
        {
            StreamReader sr = new StreamReader(@"E:\maszkolgatunk\rimworld.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string textPart = sr.ReadLine();
                fullText += textPart;
            }
            sr.Close();
            return fullText;
        }

        public string FullText
        {
            get { return fullText; }
        }
        public int NumberOfLines
        {
            get { return this.numberOfLines; }
        }
        public int NumberOfCharacters
        {
            get { return numberOfCharacters; }
        }
    }
}
