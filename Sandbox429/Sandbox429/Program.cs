using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {            var guessgame = new GuessTheNumber();
            int inputNum;
            do
            {
                guessgame.Counter();
                inputNum = int.Parse(Console.ReadLine());
                guessgame.InputNumber(inputNum);
                guessgame.Result();
            } while (inputNum != guessgame.GeneratedNumber);
            Console.WriteLine("{0}. próbálkozásra!", guessgame.Tries);
            Console.ReadKey();
        }
    }
}
