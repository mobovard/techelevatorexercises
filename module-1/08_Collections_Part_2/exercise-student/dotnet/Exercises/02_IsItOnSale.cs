using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an string item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         *
         * If the item number is empty or null, return 0.00.
         *
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         *
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *
         * IsItOnSale("kitchen4001") → 0.20
         * IsItOnSale("") → 0.00
         * IsItOnSale("GARAGE1070") → 0.15
         * IsItOnSale("dungeon9999") → 0.00
         *
         */
        public double IsItOnSale(string itemNumber)
        {
            Dictionary<string, double> itemsAndDiscounts = new Dictionary<string, double>()
            {
                {"kitchen4001", 0.20 },
                {"garage1070", 0.15 },
                {"livingroom", 0.10 },
                {"kitchen6073", 0.40 },
                {"bedroom3434", 0.60 },
                {"bath0073", 0.15 },
                
            };
            if (itemNumber == null)
            {
                return 0.00;
            }
            string itemNumberLowercase = itemNumber.ToLower();
            if (itemsAndDiscounts.ContainsKey(itemNumberLowercase))
            {
                return itemsAndDiscounts[itemNumberLowercase];
            }
                    
            return 0.00;
        }
    }
}
//given SKU return discount percentage
// need to also have it case insensitive
//if key not found return 0.00
// how to know if item is not on sale? Does that mean it is not in our dictionary?