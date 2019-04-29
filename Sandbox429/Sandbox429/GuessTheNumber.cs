using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class GuessTheNumber
    {
        private static Random r = new Random();
        private int inputNumber;
        private int generatedNumber = r.Next(1,11);
        private string answer = "";

        public int GeneratedNumber
        {
            get { return generatedNumber; }
        }

        public void InputNumber(int inputNumber)
        {
            this.inputNumber = inputNumber;
        }
        private string Umpire()
        {
            if (inputNumber > generatedNumber)
            {
                return "A számod NAGYOBB, mint a gondolt szám.";
            }
            else if(inputNumber < generatedNumber)
            {
                return "A számod KISEBB, mint a gondolt szám.";
            }
            return "You are a magician!";
        }
        public void Result()
        {
            Console.WriteLine(Umpire());
        }


    }
}
