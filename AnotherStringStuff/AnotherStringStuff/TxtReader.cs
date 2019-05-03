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
        private string specialCharacters = @"'+!%/=()~ˇˇ^^˘˘°°˛˛*-+`˙˙´´˝¨¸\|Ä€Í÷×äđĐ[]íłŁ$ß¤<>#&@{};>*?:_,.-";
        private string fullText = "";
        private int numberOfLines = 0;
        private int numberOfLetters = 0;
        private int numberOfNumbers = 0;
        private int numberOfCharacters = 0;
        private int numberOfSpecialCharacters = 0;

        public TxtReader()
        {
            this.fullText = GenerateFullText();
            this.numberOfLines = LineCounter();
            this.numberOfCharacters = CharacterCounter();
            this.numberOfLetters = LetterCounter();
            this.numberOfNumbers = NumberCounter();
            this.numberOfSpecialCharacters = SpecialCharacterCounter();
            GenerateTextWithLettersAndNumbersOnly();
        }

        private int LineCounter()
        {
            StreamReader sr = new StreamReader(@"E:\maszekolgatunk\rimworld.txt", Encoding.Default);
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
            numberOfCharacters = fullText.Length;
            return numberOfCharacters;
        }
        private int SpecialCharacterCounter()
        {
            foreach(char ch in fullText)
            {
                for (int i = 0; i < specialCharacters.Length; i++)
                {
                    if (ch == specialCharacters[i])
                    {
                        numberOfSpecialCharacters++;
                    }
                }
            }
            return numberOfSpecialCharacters;
        }
        private string GenerateFullText()
        {
            StreamReader sr = new StreamReader(@"E:\maszekolgatunk\rimworld.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string textPart = sr.ReadLine();
                fullText += textPart;
            }
            sr.Close();
            return fullText;
        }
        private void GenerateTextWithLettersAndNumbersOnly()
        {
            string newText = fullText;
            var sw = new StreamWriter(@"E:\maszekolgatunk\cucc.txt");

            foreach(char ch in newText)
            {
                if(IsLetter(ch) || IsNumber(ch))
                {
                    sw.Write(ch);
                }
            }

            sw.Close();
        }
        private bool IsLetter(char character)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (character == letters[i] || character == letters.ToUpper()[i])
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsNumber(char character)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (character == numbers[i])
                {
                    return true;
                }
            }
            return false;
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
        public int NumberOfSpecialCharacters
        {
            get { return numberOfSpecialCharacters; }
        }
    }
}
