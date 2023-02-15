namespace TestAp.ExceptionsHandling
{
    internal class ExtraFeatures
    {
        public static void F()
        {
            Console.WriteLine("Throwing MyException2 from F()");
            throw new MyException2();
        }

        public static void G() 
        {
            Console.WriteLine("Throwing MyException2 from G");
            throw new MyException2("Originated in G");
        }

        public static void H() 
        {
            Console.WriteLine("Throwing MyException2 from H() ");
            throw new MyException2("Originated in H()", 47);
        }


        //public static void Main(string[] args) 
        //{
        //    try
        //    {
        //        F();
        //    }
        //    catch (MyException2 e)
        //    {

        //        Console.Error.WriteLine(e.StackTrace);
        //    }

        //    try
        //    {
        //        G();
        //    }
        //    catch (MyException2 e)
        //    {

        //        Console.Error.WriteLine(e.StackTrace);
        //    }

        //    try
        //    {
        //        H();
        //    }
        //    catch (MyException2 e)
        //    {

        //        Console.Error.WriteLine(e.StackTrace);
        //        Console.Error.WriteLine("e.ErrorCode" + e.ErrorCode);
        //    }
        //}
    }
}
