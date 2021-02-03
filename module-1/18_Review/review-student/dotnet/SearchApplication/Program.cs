using SearchApplication.Search;
using SearchApplication.Util;
using System;
using System.Collections.Generic;

namespace SearchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Step Two: Create TELog, and log the start of the application.
                //

                TELog.Log("Search application started");

                // Step Four: Instantiate a Search Domain
                //

                SearchDomain sd = new SearchDomain("data");
                TELog.Log(sd.ToString());

                // Step Six: Single word search
                //
                SearchEngine searchEngine = new SearchEngine(sd);

                searchEngine.IndexFiles();

                Console.WriteLine("Single Word Search Result (squrrel):");

                IList<string> filesWithSquirrel = searchEngine.Search("squirrel");

                PrintListContents(filesWithSquirrel);

                // Step Seven: Multiple word search
                //

                Console.WriteLine("Multi Word Search Result (telephone line):");

                IList<string> multiWordSearchResult = searchEngine.Search("telephone line");

                PrintListContents(multiWordSearchResult);



            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception occurred:\n" + ex.StackTrace);
            }
        }

        public static void PrintListContents(IList<string> listToPrint)
        {
            if (listToPrint.Count == 0)
            {
                Console.WriteLine("No files found");
                return;
            }
            foreach (string listItem in listToPrint)
            {
                Console.WriteLine(listItem);
            }
        }
    }
}
