namespace TestAp.ExceptionsHandling.Using
{
    public class UsingCleanup : IDisposable 
    {
        public UsingCleanup()
        {
            Console.WriteLine("Constructor called");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called");
        }

    }
}
