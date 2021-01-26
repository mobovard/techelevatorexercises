namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount (string accountHolderName, string accountNumber)
           : base(accountHolderName, accountNumber)
        {

        }

        public SavingsAccount (string accountHolderName, string accountNumber, decimal balance)
            : base(accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal newBalance = Balance - amountToWithdraw;
            decimal finalAmountToWithdraw = amountToWithdraw;
            if (newBalance < 150)
            {
                finalAmountToWithdraw = finalAmountToWithdraw + 2;
            }

            newBalance = Balance - finalAmountToWithdraw;

            if (newBalance < 0)
            {
                return Balance;
            }
            return base.Withdraw(finalAmountToWithdraw);
        }
    }
}
