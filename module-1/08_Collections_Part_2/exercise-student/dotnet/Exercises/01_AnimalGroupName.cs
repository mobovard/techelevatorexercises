using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalDictionary = new Dictionary<string, string>()
            {
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder" },
                {"pigeon", "Kit" },
                {"flamingo", "Pat" },
                {"deer", "Herd" },
                {"dog", "Pack" },
                {"crocodile", "Float" }
            };
            if (animalName == null)
            {
                return "unknown";
            }
            string animalNameLowercase = animalName.ToLower();
            if (animalDictionary.ContainsKey(animalNameLowercase))
            {
                return animalDictionary[animalNameLowercase];
            }

            return "unknown";
        }
    }
}
//Should I make the dictionary in all lower case or when writing out the user input should I make theirs all toLower?
// if animalName is null then return unknown
//Need to make it so the user can put a name where animalName variable is and no matter what they type it should return the Value for that key, if not found though
//return unknown
//sometimes get confused which logic is best and get caught up when I am unsure how to exactly write it out and get random errors