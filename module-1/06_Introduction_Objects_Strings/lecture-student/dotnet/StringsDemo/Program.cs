using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            char[] word = new char[] { };
            string joe = new string(word);
            joe = "jeux";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            char firstCharacter = name[];
            char lastCharacter = name[name.Length - 1];

            Console.WriteLine($"The first chracter is {firstCharacter} and the last character is {lastCharacter}");

           

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeCharacters = name.Substring(0, 3);

            Console.WriteLine($"First 3 characters: {firstThreeCharacters}");


            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            string lastThreeCharacters = name.Substring(name.Length - 3);

            Console.WriteLine($"First and Last 3 characters: {firstThreeCharacters}{lastThreeCharacters}");

            // 4. What about the last word?
            // Output: Lovelace

            string[] words = name.Split(' ');

            Console.WriteLine("Last Word:  {word[ word.Length-1 ]}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            bool containsLove = name.Contains"Love";

            Console.WriteLine("Contains \"Love\"");

            // 6. Where does the string "lace" show up in name?
            // Output: 8


            int locationOfLace = name.IndexOf("lace");

            Console.WriteLine("Index of \"lace\" in Ada Lovelace: {locationOfLace}");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            int numberOfA = name.IndexOf("a");

            Console.WriteLine("Number of \"a's\": ");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            // Console.WriteLine(name);

            // 9. Set name equal to null.

            // 10. If name is equal to null or "", print out "All Done".

            Console.ReadLine();
        }
    }
}