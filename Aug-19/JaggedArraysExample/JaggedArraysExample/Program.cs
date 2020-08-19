using System;

namespace JaggedArraysExample
{
    class Program
    {
        static void Main()
        {
            //jagged array
            string[][] phoneNumbers = new string[5][];
            phoneNumbers[0] = new string[1] { "98989898" };
            phoneNumbers[1] = new string[3] { "873487348", "999384983", "3948223" };
            phoneNumbers[2] = new string[2] { "12121212", "989898" };
            phoneNumbers[3] = new string[4] { "672349023", "663498723", "34982323", "29982398" };
            phoneNumbers[4] = new string[0] { };

            //for loop
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < phoneNumbers[i].Length; j++)
                {
                    Console.Write(phoneNumbers[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine(); //goes to next line
            }

            Console.ReadKey();
        }
    }
}


