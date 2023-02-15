namespace TestAp.ExampleClasses
{
    internal class Television
    {
        int channel = 2;
        internal int Channel
        {
            get { return channel; }
            set
            {
                Console.WriteLine("Everyone sees {0}", value);
                channel = value;
            }
        }
    }
}
