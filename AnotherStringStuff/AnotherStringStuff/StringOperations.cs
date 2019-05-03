using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherStringStuff
{
    class StringOperations
    {
        private string fullText = "";
        private const string letters = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
        private const string numbers = "0123456789";
        private const string specialCharacters = @"'+!%/=()~ˇˇ^^˘˘°°˛˛*-+`˙˙´´˝¨¸\|Ä€Í÷×äđĐ[]íłŁ$ß¤<>#&@{};>*?:_,.-";
        protected static int numberOfWordsInText = 0;

        protected int CountTheWordsInText()
        {
            int lettersInWord = 0;

            foreach (char ch in fullText)
            {
                if (IsLetter(ch))
                {
                    lettersInWord++;
                }
                else
                {
                    if (lettersInWord >= 2)
                    {
                        numberOfWordsInText++;
                        lettersInWord = 0;
                    }
                    lettersInWord = 0;
                }
            }
            return numberOfWordsInText;
        }
        protected void GetTheWordsFromText()
        {
            string[] wordsInText = new string[numberOfWordsInText];
            string wordFromText = "";
            int lettersInWord = 0;
            int indexCounter = -1;

            foreach (char ch in fullText)
            {
                if (IsLetter(ch))
                {
                    wordFromText += ch;
                    lettersInWord++;
                }
                else
                {
                    if (lettersInWord >= 2)
                    {
                        numberOfWordsInText++;
                        indexCounter++;
                        wordsInText[indexCounter] = wordFromText;

                        lettersInWord = 0;
                        wordFromText = "";
                    }
                    lettersInWord = 0;
                    wordFromText = "";
                }
            }
        }

        protected bool IsLetter(char character)
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
        protected bool IsNumber(char character)
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
        protected bool IsSpecial(char character)
        {
            for (int i = 0; i < specialCharacters.Length; i++)
            {
                if (character == specialCharacters[i])
                {
                    return true;
                }
            }
            return false;
        }
        protected void GetTheText(string fullText)
        {
            this.fullText = fullText;
        }

    }
}
