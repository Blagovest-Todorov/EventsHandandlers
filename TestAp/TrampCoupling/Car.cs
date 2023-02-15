using System.Drawing;
namespace TestAp.TrampCoupling   
{ 
    internal class Car
    {
        void BuildCar(Color bodyColor) 
        {
            BuildChassis(bodyColor);
        }

        void BuildChassis(Color bodyColor) 
        {
            InstallingEngine(bodyColor);
        }

        private void InstallingEngine(Color bodyColor)
        {
            PutOnTires(bodyColor);
        }

        private void PutOnTires(Color bodyColor)
        {
            
        }

        //public static void Main()
        //{
        //    Car c = new Car();
        //    c.BuildCar(Color.Red);
        //}
    }
}
