using System;
using System.Collections;
namespace StringSolver
{
    class StringSolver
    {
        static void Main(string[] args)
        {
            string test = "abcdefdghjkl";
            string test2 = "aabbccddee";
            string test3 = "ababacacadad";
            StringSolver stringSolver = new StringSolver();
            Console.WriteLine("First Recurring Character Test1: " + stringSolver.FindFirstRecurringCharacter(test));
            Console.WriteLine("First Recurring Character Test2: " + stringSolver.FindFirstRecurringCharacter(test2));
            Console.WriteLine("First Recurring Character Test3: " + stringSolver.FindFirstRecurringCharacter(test3));
        }
        /*
        name: FindFirstReccuringCharacter
        in: any string 
        out: first recurring character
        description: Find the first recurring character in a string ex. AAAAB -> A , ABCDDEFGH -> D
         */
        public char FindFirstRecurringCharacter(string recurString)
        {
            if (recurString == null)
                return '0';
            Hashtable characterTable = new Hashtable();
            char[] characters = recurString.ToCharArray();
            int numChars = characters.Length;
            int counter = 0;
            char repeatingCharacter = '0';
            if (numChars < 2)
                return '0';
            while (counter < numChars)
            {
                if (!characterTable.Contains(characters[counter]))
                    characterTable.Add(characters[counter], 1);
                else
                    return characters[counter];
                counter++;
            }
            return repeatingCharacter;
        }
    }
}

