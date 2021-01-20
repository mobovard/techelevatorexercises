using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<int> numbers = new List<int>() { 1, 2 };
			
			numbers.Add(3);

			List<string> adventureTimeCharacters = new List<string>() {"Marceline", "Finn", "Jake" };
			adventureTimeCharacters.Add("Princess Bubblegum");

			for(int i = 0; i < adventureTimeCharacters.Count; i++)
            {
				Console.WriteLine(adventureTimeCharacters[i]);
            }

			foreach (string character in adventureTimeCharacters)
            {
				Console.WriteLine(character);
            }

			//the foreach is what returns the list to see what our output is. Can be written under each example to be able to run the code
			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			adventureTimeCharacters.Add("Finn");
            foreach (string character  in adventureTimeCharacters)
            {
				Console.WriteLine(character);
            }

			return;

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			//lists do allow you to add duplicates and we get no errors when running the next line

			adventureTimeCharacters.Add("Finn");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			adventureTimeCharacters.Insert(2, "Ice King");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			//remove by index
			adventureTimeCharacters.RemoveAt(2);

			//remove by string - it is case sensitive so you can't type remove("finn")
			//when using .remove it will only delete the first instance of the string "Finn"
			adventureTimeCharacters.Remove("Finn");


			//Can't remove characters as you are looping through. Will seriously break code
			// you can do it the way below where you make a new string to add the characters to that ARE NOT Finn
			List<string> adventureTimeCharactersWithoutFinn = new List<string>();
			foreach (string character in adventureTimeCharacters)
            {
				if (character != "Finn")
                {
					adventureTimeCharacters.Add(character);
                }
            }


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			bool isJakeInList = adventureTimeCharactersWithoutFinn.Contains("Jake");
			Console.WriteLine($"Is Jake in List: {isJakeInList}");

			//will return true in console

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			
			Console.WriteLine($"Jake's location is at index: {adventureTimeCharactersWithoutFinn.IndexOf("Jake")}");
			//finds first instance of the string only

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] charactersAsArray = adventureTimeCharactersWithoutFinn.ToArray();

			List<string> backToList = new List<string>(charactersAsArray);
			//just for note taking purposes to show how you can turn back to the list after turning into array

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();


		}
	}
}
