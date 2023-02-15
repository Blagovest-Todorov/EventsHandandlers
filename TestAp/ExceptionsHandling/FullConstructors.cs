namespace TestAp.ExceptionsHandling
{
    internal class FullConstructors
    {
        public static void F()
        {
            Console.WriteLine("Throwing  MyException from  F()");
            throw new MyException();
        }

        public static void G()
        {
            Console.WriteLine("Throwing MyException from G()");
            throw new MyException("Originated in G");
        }

        public static void I() 
        {
            Console.WriteLine("This will cause trouble");
            int y = 0;
            int x = 1 / y;
        }

        public static void H() 
        {
            try
            {
                I();
            }
            catch (Exception)
            {

                Console.WriteLine("Increasing  abstraction level");
                throw new MyException("Originated in H()");
            }
        }

        //public static void Main() 
        //{
        //    try
        //    {
        //        F();
        //    }
        //    catch (MyException e)
        //    {

        //        Console.Error.WriteLine(e.StackTrace);
        //    }

        //    try
        //    {
        //        G();
        //    }
        //    catch (MyException e)
        //    {

        //        Console.Error.WriteLine(e.Message);
        //    }

        //    try
        //    {
        //        H();
        //    }
        //    catch (MyException e)
        //    {

        //        Console.Error.WriteLine(e.Message);
        //        Console.Error.WriteLine("Inner exception: " + e.InnerException);
        //        Console.Error.WriteLine("Source: " + e.Source);
        //        Console.Error.WriteLine("TargetSite: " + e.TargetSite);
        //    }
      //  }
    }
}
