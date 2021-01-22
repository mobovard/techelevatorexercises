using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         *
         * PeterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * PeterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         *
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            int peterMoney = peterPaul["Peter"];
            int PaulMoney = peterPaul["Paul"];

            if (peterMoney >= 5000 && PaulMoney >= 10000 )
            {
                int PeterPaulPartnership = (1 / 4 * (peterMoney)) + (1 / 4 * (PaulMoney));
                peterPaul.Add("PeterPaulPartnership", PeterPaulPartnership);
                int newPeterMoney = peterMoney - (1 / 4 * (peterMoney));
                int newPaulMoney = PaulMoney - (1 / 4 * (PaulMoney));
                peterPaul["Peter"] = newPeterMoney;
                peterPaul["Paul"] = newPaulMoney;
            }

            return peterPaul;
        }
    }
}
//start with does peter have > 50 and does paul have > 100
// if yes then take 1/4 of each of their worth and add together in a new entry in the dictionary
//