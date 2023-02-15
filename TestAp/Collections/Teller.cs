using System.Collections;

namespace TestAp.Collections
{
    internal class Teller
    {
        Queue line = new Queue();
        internal void EnterLine(Customer c)
        {
            line.Enqueue(c);
        }

        //internal void Checkout()
        //{
        //    Customer c = (Customer)line.Dequeue();
        //    Console.WriteLine("Checking out: " + c.Name);
        //}
    }
}
