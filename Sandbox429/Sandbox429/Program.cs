using System;

namespace Sandbox429
{
    class Program
    {
        static void Main(string[] args)
        {            var guessgame = new GuessTheNumber();
            int inputNum;
            do
            {
                inputNum = int.Parse(Console.ReadLine());
                guessgame.InputNumber(inputNum);
                guessgame.Result();
            } while (inputNum != guessgame.GeneratedNumber);
            Console.ReadKey();
        }
    }
}
