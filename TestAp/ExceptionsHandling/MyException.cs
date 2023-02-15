namespace TestAp.ExceptionsHandling
{
    internal class MyException : Exception
    {
        public MyException() : base() { }
        public MyException( string msg) : base(msg) { }
        public MyException( string msg, Exception inner ) : base(msg) { }

    }
}
