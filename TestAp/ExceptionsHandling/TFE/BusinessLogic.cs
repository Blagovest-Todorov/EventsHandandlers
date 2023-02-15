namespace TestAp.ExceptionsHandling.TFE
{
    public class BusinessLogic
    {
        Transaction myTransaction = new Transaction();
        public void DoCharge()
        {
            try
            {
                myTransaction.Process();
                Console.WriteLine("Transaction ok");
            }
            catch (TransactionsFailureException tfe)
            {

                Console.WriteLine(tfe.Message);
                Console.Error.WriteLine(tfe.InnerException);
            }
        }

        //public static void Main() 
        //{
        //   BusinessLogic bl =  new BusinessLogic();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        bl.DoCharge();
        //    }
        //}
    }
}
