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
                    for (int i=1; i<=300; i++)
                    {
                        string valueToWrite = $"{i}";
                        string currentValue = $"{i}";
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            valueToWrite = "FizzBuzz";
                        }
                        else if (i % 3 == 0)
                        {
                            valueToWrite = "Fizz";
                        }
                        else if (i % 5 == 0)
                        {
                            valueToWrite = "Buzz";
                        }
                        else if (currentValue.Contains("3"))
                        {
                            valueToWrite = "Fizz";
                        }
                        else if (currentValue.Contains("5"))
                        {
                            valueToWrite = "Buzz";
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


