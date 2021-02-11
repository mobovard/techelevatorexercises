using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the destination file?");
            string destinationFile = Console.ReadLine();
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(destinationFile))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        string valueToWrite = $"{i}";
                        string currentValue = $"{i}";
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            valueToWrite = "FizzBuzz";
                        }
                        else if (i % 5 == 0 || currentValue.Contains("5"))
                        {
                            valueToWrite = "Buzz";
                        }
                        else if (i % 3 == 0 || currentValue.Contains("3"))
                        {
                            valueToWrite = "Fizz";
                        }

                        streamWriter.WriteLine(valueToWrite);
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


