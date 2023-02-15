namespace TestAp.SoundEquipment
{
    internal class CdPlayer : SoundEquipment
    {
        static new void SayChannels() 
        {
            Console.WriteLine("All CD players have 2 channels");
        }

        internal override void AdjustSound()
        {
            Console.WriteLine("Adjusting total volume");
        }
    }
}
