namespace TestAp.ExceptionsHandling
{
    internal class MyException2 : Exception
    {
        int errorCode;
        public int ErrorCode 
        {
            get { return errorCode; }
        }

        public MyException2() : base() { }
        public MyException2(string msg) : base(msg) { }
        public MyException2(string msg, int erroCode) : base(msg) 
        {
           this.errorCode = erroCode;
        }
    }
}
