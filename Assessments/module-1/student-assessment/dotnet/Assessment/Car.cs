using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Car
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
            set
            {
            }
        }

        public Car(int year, string make, bool isClassicCar)
        {
            Year = year;
            Make = make;
            IsClassicCar = IsClassicCar;
        }


    }
}
