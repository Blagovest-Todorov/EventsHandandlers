namespace TestAp.Synchronous_Programing
{
    public class AsyncronosProgram
    {
        static async Task Main(string[]args) 
        {
            LongProcess();
            ShortProcess();
        }


        private static async void LongProcess()
        {
            Console.WriteLine("LongProcess Started");
            await Task.Delay(4000); // hold execution for 4 second.
            Console.WriteLine("LongProcess Completed");
        }
        private static async void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started.");

            // do something here

            Console.WriteLine("ShortProcess Completed.");
        }
    }
}
