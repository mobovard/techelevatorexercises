using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length: ");
            string lengthString;
            lengthString = Console.ReadLine();
            int lengthInt = int.Parse(lengthString);

            Console.WriteLine("Is the meausurement in (m)eter, or (f)eet?");
            string lengthType;
            lengthType = Console.ReadLine();


            int convertedLength = 0;
            string convertedType = "";
            if (lengthType == "m")
            {
                convertedLength = (int)(lengthInt * 3.2808399);
                convertedType = "f";
            }
            else if (lengthType == "f")
            {
                convertedLength = (int)(lengthInt * 0.3048);
                convertedType = "m";
            }


            Console.WriteLine($"{lengthInt}{lengthType} is {convertedLength}{convertedType}."
                );
        }
    }
}
