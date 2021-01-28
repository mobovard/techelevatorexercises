using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                int totalWorth = 0;
                foreach (IAccountable account in AccountList)
                {
                    totalWorth = totalWorth + account.Balance;
                }
                if (totalWorth >= 25000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public BankCustomer()
        {
            AccountList = new List<IAccountable>();
        }

        private List<IAccountable> AccountList;

        public void AddAccount(IAccountable newAccount)
        {
            AccountList.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return AccountList.ToArray();

        }

    }
}
