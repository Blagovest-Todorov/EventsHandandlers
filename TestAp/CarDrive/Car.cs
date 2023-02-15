namespace TestAp.CarDrive
{
    internal abstract class Car
    {
        abstract public void Start();
        protected void QuickStart() 
        {
            InsertKey();
            TurnKey();
        }

        private void TurnKey()
        {
            throw new NotImplementedException();
        }

        private void InsertKey()
        {
            throw new NotImplementedException();
        }
    }
}
