using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####################");
            Console.WriteLine("       DICTIONARIES");
            Console.WriteLine("####################");
            Console.WriteLine();

            Dictionary<string, string> stateCapitals = new Dictionary<string, string>();

            stateCapitals.Add("KY", "Frankfort");

            stateCapitals["OH"] = "Columbus";

            string floridaCaptial = stateCapitals["FL"];

            // group activity
            // create 2 dictionaries of key int and value string
            // add 4 rows to each dictionary
            // combines them into a single dictionary
            // if key exists, value plus value

            Dictionary<int, string> dictOne = new Dictionary<int, string>();
            Dictionary<int, string> dictTwo = new Dictionary<int, string>();

            dictOne[1] = "red";
            dictOne[2] = "orange";
            dictOne[3] = "yellow";
            dictOne[4] = "green";

            dictTwo[5] = "blue";
            dictTwo[6] = "purple";
            dictTwo[7] = "indigo";
            dictTwo[8] = "pink";

            Dictionary<int, string> dictCombined = new Dictionary<int, string>();
            foreach (KeyValuePair<int, string> kvp in dictOne)
            {
                dictCombined[kvp.Key] = kvp.Value;
            }
            foreach (KeyValuePair<int, string> kvp in dictTwo)
            {
                dictCombined[kvp.Key] = kvp.Value;
            }
            foreach (KeyValuePair<int, string> kvp in dictCombined)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            // this way is fine but could have just added to one of the dictionaries instead of making a new one
            // just in case there are duplicates it might be a good idea to check for dupes?
        }
    }
}
