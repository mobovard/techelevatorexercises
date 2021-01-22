using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            var wordCountDictionary = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string currentString = words[i];

                if (wordCountDictionary.ContainsKey(currentString))
                {
                    wordCountDictionary[currentString] = wordCountDictionary[currentString] + 1;
                }
                else
                {
                    wordCountDictionary.Add(currentString, 1);
                }

            }
            return wordCountDictionary;
       
        }
    }
}

//given an array of strings need to get the key is a string and the value is the number of times it appears
//loop through array and use if/ else. increment value each time it appears
//
