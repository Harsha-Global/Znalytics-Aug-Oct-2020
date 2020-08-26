using System;

namespace EmailValidationExample
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starting point of the execution
        /// </summary>
        static void Main()
        {
            /*Email validation:
             * 1. No space
             * 2. @ symbol should be present
             * 3. @ should be present only once
             * 4. Some special characters like : , not allowed
             * 5. Ends with .com or .co.in or .co.uk etc.
             */


            //reading email from keyboard
            string email;
            Console.WriteLine("Email: ");
            email = Console.ReadLine();

            //searching for space
            bool spaceFound = email.Contains(" ");

            //searching for @
            bool AtFound = email.Contains("@");

            char[] ch = email.ToCharArray();
            int AtCharCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '@')
                {
                    AtCharCount++;
                }
            }

            if (!spaceFound && AtFound && AtCharCount == 1 && (email.EndsWith(".com") || email.EndsWith(".co.in") || email.EndsWith(".co.uk")) )
            {
                Console.WriteLine("Valid Email address");
            }
            else
            {
                Console.WriteLine("Email should contain only one @ symbol; no space and also end with .com");
            }

            Console.ReadKey();
        }
    }
}
