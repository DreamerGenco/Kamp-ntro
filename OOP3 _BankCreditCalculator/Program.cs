namespace OOP3__BankCreditCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ICreditManager consomerLoanManager = new ConsomerLoanManager();
            
          //ICreditManager vehicleLoanManager = new VehicleLoanManager();
            
          ICreditManager mortgageLoanManger = new MortgageLoanManager();
          
          CreditRequestManager creditRequestManager = new CreditRequestManager();
            creditRequestManager.MakeApplication(new VehicleLoanManager());
        }
    }
}