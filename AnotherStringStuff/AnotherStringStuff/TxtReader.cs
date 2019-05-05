using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnotherStringStuff
{
    class TxtReader : StringOperations
    {
        private int numberOfLines = 0;
        private int numberOfLetters = 0;
        private int numberOfNumbers = 0;
        private int numberOfCharacters = 0;
        private int numberOfSpecialCharacters = 0;

        public TxtReader()
        {
            this.numberOfLines = LineCounter();
            this.numberOfCharacters = CharacterCounter();
            this.numberOfLetters = LetterCounter();
            this.numberOfNumbers = NumberCounter();
            this.numberOfSpecialCharacters = SpecialCharacterCounter();
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
        public int WordsInText
        {
            get { return numberOfWordsInText; }
        }
        public string AllWords
        {
            get { return allWords[0]; }
        }
        public string TheLongest
        {
            get { return LongestWord(); }
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
            for (int i = 0; i < fullText.Length; i++)
            {
                if (IsLetter(fullText[i]))
                {
                    numberOfLetters++;
                }
            }
            return numberOfLetters;
        }
        private int NumberCounter()
        {
            foreach (char ch in fullText)
            {
                if (IsNumber(ch))
                {
                    numberOfNumbers++;
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
            for (int i = 0; i < fullText.Length; i++)
            {
                if (IsSpecial(fullText[i]))
                {
                    numberOfSpecialCharacters++;
                }
            }
            return numberOfSpecialCharacters;
        }
        private string LongestWord()
        {
            string theLongestWord = "";
            int theLongestWordLength = int.MinValue;
            int theLongestWordIndex = 0;

            for (int i = 0; i < allWords.Length; i++)
            {
                if (theLongestWordIndex < allWords[i].Length)
                {
                    theLongestWordLength = allWords[i].Length;
                    theLongestWordIndex = i;
                }
            }
            theLongestWord = allWords[theLongestWordIndex];
            return theLongestWord;
        }
        private string MostCommonlyUsedWord()
        {
            string lastWord = "";
            string theMostUsedWord = "";
            int theMostCommonlyUsedWordTimes = 0;
            int theLongestWordIndex = 0;

            for (int i = 0; i < allWords.Length ; i++)
            {
                for (int j = 0; j < length; j++)
                {

                }
            }


            return theMostUsedWord;
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


    }
}
