namespace TestAp.Synchronous_Programing
{
    public class Synchronous
    {
        public static void Main(string[]args) 
        {
            LongProcess();
            ShortProcess();
        }

        private static void LongProcess()
        {
            Console.WriteLine("LongProcess Started.");
            Thread.Sleep(4000); 
            Console.WriteLine("LongProcess Completed.");

        }
        private static void ShortProcess()
        {
            Console.WriteLine("ShortProcess  started");
            Console.WriteLine("ShortProcess  completed");
        }
    }  
}
