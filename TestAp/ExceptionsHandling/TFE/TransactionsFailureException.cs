namespace TestAp.ExceptionsHandling.TFE
{
    public class TransactionsFailureException : ApplicationException
    {
        public TransactionsFailureException(Exception e) : base("Logical failure caused by low-level " + "exception", e)
        {

        }
    }
}
