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
        protected string simpleTextForTest = "Egy,. ket , ha. negGysd, aZ. ";
        private string letters = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
        private string numbers = "123456789";
        private string specialCharacters = @"'+!%/=()~ˇˇ^^˘˘°°˛˛*-+`˙˙´´˝¨¸\|Ä€Í÷×äđĐ[]íłŁ$ß¤<>#&@{};>*?:_,.-";
        protected static int numberOfWordsInText = 0;s
        private string[] wordsInText = new string[numberOfWordsInText];


        public int CountTheWordsInText(string someText)
        {
            int lettersInWord = 0;

            foreach (char ch in someText)
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
