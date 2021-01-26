namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
       
        public CheckingAccount(string accountHolderName, string accountNumber)
            :base (accountHolderName, accountNumber)
        {
                       
        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance)
            :base (accountHolderName, accountNumber, balance)
        {
           
        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal newBalance = Balance - amountToWithdraw;
            decimal finalAmountToWithdraw = amountToWithdraw;
            if (newBalance < -100)
            {
                return Balance;
            }
            if (newBalance < 0)
            {
                finalAmountToWithdraw = finalAmountToWithdraw + 10;
            }

            return base.Withdraw(finalAmountToWithdraw);
        }
    }
}
