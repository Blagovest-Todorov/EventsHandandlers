namespace TestAp.CarDrive
{
    internal class StickShift : Car
    {
        public override void Start()
        {
            PutInNeutral();
            QuickStart();
        }

        private void PutInNeutral()
        {
            throw new NotImplementedException();
        }
    }
}
