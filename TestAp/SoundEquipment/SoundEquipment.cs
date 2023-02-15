using System.Diagnostics.Contracts;

namespace TestAp.SoundEquipment
{
    internal class SoundEquipment
    {
        internal static void SayChannels() 
        {
            Console.WriteLine("I dont know how many");
        }

        internal virtual void AdjustSound() 
        {
            Console.WriteLine("No default adjustment");
        }

        //public static void Main() 
        //{
        //    SoundEquipment[] components = {new CdPlayer(), new DolbyDecoder()};

        //    foreach (SoundEquipment se in components)
        //    {
        //        SoundEquipment.SayChannels();
        //        se.AdjustSound();
        //    }   
        //}

    }
}
