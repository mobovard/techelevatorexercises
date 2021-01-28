using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt { get; private set; }
        public int Balance
        {
            get
            {
                return Debt * -1;
            }

        }

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Debt = 0;
        }

        public int Pay(int amountToPay)
        {
            Debt = Debt - amountToPay;
            return Debt;
        }

        public int Charge (int amountToCharge)
        {
            Debt = Debt + amountToCharge;
            return Debt;
        }

    }
}
