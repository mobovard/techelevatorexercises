using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Program

    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\Student\workspace\mbovard-c\Assessments\module-1\student-assessment\dotnet\Assessment\Data\CarInput.csv";

            List<Car> carList = new List<Car>();

            {

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] carArray = line.Split(",");

                            int year = Convert.ToInt32(carArray[0]);
                            string model = carArray[1];
                            bool isClassicCar = Convert.ToBoolean(carArray[2]);

                            Car car = new Car(year, model, isClassicCar);

                            carList.Add(car);



                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                int ageSum = 0;
                foreach (Car car in carList)
                {
                    ageSum += car.Age;
                }

                Console.WriteLine($"Total age of all cars: {ageSum}");
            }

        }


    }
}
