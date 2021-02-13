using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public bool IsClassicCar { get; set; }
        public int Age
        {
            get
            {
                int age = 2021 - Year;
                return age;
            }
        }

        public Car(int year, string make, bool isClassicCar)
        {
            Year = year;
            Make = make;
            IsClassicCar = IsClassicCar;
        }

        public override string ToString()
        {
            return $"CAR  - {Year} - {Make}";
        }



        public bool ECheck(int yearToCheck)
        {
            if (Age < 4 || Age > 25 || IsClassicCar == true)
            {
                return false;
            }
            else if (Year % 2 == 0 && yearToCheck % 2 == 0)
            {
                return true;
            }
            else if (Year % 2 != 0 && yearToCheck % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                        
        }
    }
}
