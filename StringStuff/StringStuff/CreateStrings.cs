using System;

namespace StringStuff
{
    class CreateStrings
    {
        private static Random r = new Random();
        private string letters = "qwertzuiopasdfghjkl123456789xcvbnm";

        public string CreateRandomName()
        {
            string generatedName = "";

            do
            {
                generatedName += letters[r.Next(0, letters.Length)];

            } while (generatedName.Length != 5);

            generatedName += ".txt";
            return generatedName;
        }

    }
}
