namespace TestAp.ExceptionsHandling
{
    internal class SimpleExceptionDemo
    {
        public void F() 
        {
            Console.WriteLine("Throwing SimpleException from F()");
            throw new SimpleException();
        }

        //public static void Main() 
        //{
        //    SimpleExceptionDemo sed = new SimpleExceptionDemo();

        //    try
        //    {
        //        sed.F();
        //    }
        //    catch (SimpleException)
        //    {

        //        Console.Error.WriteLine("Caught it!");
        //    }
        //}
    }
}
