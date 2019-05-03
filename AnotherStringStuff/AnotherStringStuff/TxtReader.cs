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
        private string letters = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
        private string numbers = "123456789";
        private string fullText = "";
        private int numberOfLines = 0;
        private int numberOfLetters = 0;
        private int numberOfNumbers = 0;
        private int numberOfCharacters = 0;

        public TxtReader()
        {
            this.fullText = GenerateFullText();
            this.numberOfLines = LineCounter();
            this.numberOfCharacters = CharacterCounter();
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
            sr.Close();
            return numberOfLines;
        }
        private int LetterCounter()
        {
            foreach (char ch in fullText)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (ch == letters[i] || ch == letters.ToUpper()[i])
                    {
                        numberOfLetters++;
                    }
                }
            }
            return numberOfLetters;
        }
        private int NumberCounter()
        {
            foreach (char ch in fullText)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (ch == numbers[i])
                    {
                        numberOfNumbers++;
                    }
                }
            }
            return numberOfNumbers;
        }
        private int CharacterCounter()
        {
            StreamReader sr = new StreamReader(@"E:\maszkolgatunk\rimworld.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
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
                fullText += "\n" + textPart;
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
        public int NumberOfLetters
        {
            get { return numberOfLetters; }
        }
        public int NumberOfNumbers
        {
            get { return numberOfNumbers; }
        }
    }
}
