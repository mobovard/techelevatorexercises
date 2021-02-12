using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Program

    {
        public void Main(string[] args)
        {
            string filePath = @"C:\Users\Student\workspace\mbovard-c\Assessments\module-1\student-assessment\dotnet\Assessment\Data\CarInput.txt";

          //  List<Car> List(string filePath)
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

                            List<Car> carList = new List<Car>();
                            carList.Add(car);

                          
                           
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return List<Car>;
            }


           // public override string ToString()
        //{
            
          //  return $"CAR - {year} - {make}";
        //}

    }


    }
}
