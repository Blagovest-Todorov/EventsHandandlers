namespace TestAp.Instruments
{
    internal class WoodWind : Wind
    {
        public override void Play() 
        {
            Console.WriteLine("WoodWiond.Play ()");
        }

        public override string What() 
        {
            return "WoodWind";
        }
    }
}
