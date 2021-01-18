using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {



            
            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");

            string discountAmountAsString;
            discountAmountAsString = Console.ReadLine();
            double discountPercentage = double.Parse(discountAmountAsString);
            discountPercentage = discountPercentage * .01;                                                                     


            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");

            string itemPrices;
            itemPrices = Console.ReadLine();

            string[] itemPricesAsArray = itemPrices.Split(' ');

            itemPricesAsArray = itemPricesAsArray;

            for (int i = 0; i < itemPricesAsArray.Length; i++)
            {
                decimal priceAsDecimal;
                priceAsDecimal = decimal.Parse(itemPricesAsArray[i]);

                decimal amountOff = priceAsDecimal * (decimal)discountPercentage;
                decimal salePrice = priceAsDecimal - amountOff;
                Console.WriteLine("Discounted Price " + salePrice + " Original Price " + priceAsDecimal);

                

            }





        }
    }
}
