using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature: ");
            string temperatureString;
            temperatureString = Console.ReadLine();
            int temperatureInt = int.Parse(temperatureString);

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?");
            string temperatureType;
            temperatureType = Console.ReadLine();

            
            int convertedTemperature = 0;
            string convertedType = "";
            if (temperatureType == "F")
            {
                convertedTemperature = (int)((temperatureInt - 32) / 1.8);
                convertedType = "C";
            }
            else if (temperatureType == "C")
            {
                convertedTemperature = (int)(temperatureInt * 1.8 + 32);
                convertedType = "F";
            }


            Console.WriteLine($"{temperatureInt}{temperatureType} is {convertedTemperature}{convertedType}."
                );
        }
    }
}
