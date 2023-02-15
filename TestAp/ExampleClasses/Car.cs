using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Car
    {
        public Engine engine = new Engine();
        public Wheel[] wheels = new Wheel[4];
        public Door left = new Door(),
                    right = new Door();

        public Car()
        {
            for (int i = 0; i < wheels.Length; i++)
            {
                wheels[i] = new Wheel();
            }
        }

        //public static void Main()
        //{
        //    Car car = new Car();
        //    car.left.window.Rollup();
        //    //car.right.window.Rolldown();
        //    car.wheels[0].Inflate(72);
        //    // inhreistance is expresses with is a - relation, 
        //    // composition is expressed with has a -relation !
        //    Console.WriteLine(car);
        //}
    }
}
