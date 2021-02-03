using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path

            Console.WriteLine("What is the fully qualified name of the file ?");

            string filePath = Console.ReadLine();

            //2. Ask the user for the search string

            Console.WriteLine("What is the search word you are looking for?");

            string searchWord = Console.ReadLine();


            Console.WriteLine("Should the search be case sensitive? (Y/N)");

            string caseSensitive = Console.ReadLine().ToUpper();


            //3. Open the file

            try
            {
                using (StreamReader streamReader = File.OpenText(filePath))
                {
                    int lineNumber = 1;

                    string stringLine;

                    while ((stringLine = streamReader.ReadLine()) != null)
                    {
                        if (caseSensitive == "Y")
                        {
                            if (stringLine.Contains(searchWord))
                            {

                                Console.WriteLine($"{lineNumber}) {stringLine}");
                            }
                        }

                        else
                        {
                            string lowerSearchWord = searchWord.ToLower();
                            string lowerStringLine = stringLine.ToLower();

                            if (lowerStringLine.Contains(lowerSearchWord))
                            {

                                Console.WriteLine($"{lineNumber}) {stringLine}");
                            }
                        }

                        lineNumber += 1;

                    }
                }
            }

            catch
            {
                Console.WriteLine("path not found");
                Console.ReadLine();
            }

            //4. Loop through each line in the file


            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
