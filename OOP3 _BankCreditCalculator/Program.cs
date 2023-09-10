namespace OOP3__BankCreditCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ICreditManager consomerLoanManager = new ConsomerLoanManager();
            
          ICreditManager vehicleLoanManager = new VehicleLoanManager();
            
          ICreditManager mortgageLoanManger = new MortgageLoanManager();
            
           ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            
           ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

           CreditRequestManager creditRequestManager = new CreditRequestManager();
            List<ILoggerService>loggers = new List<ILoggerService>() { dataBaseLoggerService, smsLoggerService };
           creditRequestManager.MakeApplication(vehicleLoanManager,loggers);
           creditRequestManager.MakeApplication(new StandbyCredit(),loggers);


          List<ICreditManager> credits = new List<ICreditManager>() {consomerLoanManager, vehicleLoanManager,mortgageLoanManger};

          //creditRequestManager.CreditPreliminaryInformation(credits);



        }
    }
}