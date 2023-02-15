namespace TestAp.SoundEquipment
{
    internal class DolbyDecoder : SoundEquipment
    {
        static new void SayChannels() 
        {
            Console.WriteLine("All DolbyDecoders have 5+1 channels");
        }

        internal override void AdjustSound()
        {
            Console.WriteLine("Adjusting effects channel");
        }
    }
}
