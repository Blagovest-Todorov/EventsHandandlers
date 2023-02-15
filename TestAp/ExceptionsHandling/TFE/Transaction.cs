namespace TestAp.ExceptionsHandling.TFE
{
    public class Transaction
    {
        Random r = new Random();

        public void Process()
        {
            try
            {
                if (r.NextDouble() > 0.3)
                {
                    throw new ArithmeticException();
                }
                else
                {
                    if (r.NextDouble() > 0.5)
                    {
                        throw new FormatException();
                    }
                }
            }
            catch (Exception e)
            {

                TransactionsFailureException tfe = new TransactionsFailureException(e);
                throw tfe;
            }
        }
    }
}
