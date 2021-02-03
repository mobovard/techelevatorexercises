using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ask for the user input and store it for later use
            //C:\Users\Student\workspace\mbovard-c\module-1\17_FileIO_Writing_out\exercise-student\dotnet\my_file.txt

            Console.WriteLine("What is the search word?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What is the replacement word?");
            string replacementWord = Console.ReadLine();

            Console.WriteLine("What is the source file?");
            string sourceFile = Console.ReadLine();

            Console.WriteLine("What is the destination file?");
            string destinationFile = Console.ReadLine();

            //find all instances of the search word and then replace it with the replacement word
            //looking at the source file and changing it and outputting it to the destination file
            //this is case sensitive!

            try
            {
                string str;

                using (StreamReader streamReader = File.OpenText(sourceFile))
                {
                    using (StreamWriter streamWriter = new StreamWriter(destinationFile))
                    {
                        while ((str = streamReader.ReadLine()) != null)
                        {
                            if (str.Contains(searchWord))
                            {
                                string replacedStr = str.Replace(searchWord, replacementWord);

                                Console.WriteLine($"Line found, word replaced: {replacedStr}");

                                streamWriter.WriteLine(replacedStr);
                                //StreamWriter write = new StreamWriter(destinationFile);
                            }
                            else
                            {
                                streamWriter.WriteLine(str);
                            }
                        }
                    }
                }
            }

            catch
            {
                Console.WriteLine("path not found");
                Console.ReadLine();
            }


        }
    }
}
