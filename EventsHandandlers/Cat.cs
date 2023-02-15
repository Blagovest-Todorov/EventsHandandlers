using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandandlers
{
    public class Cat
    {
        private int health;

        public int Id { get; set; }

        public string Name { get; set; }

        public int Health 
        {
            get => this.health;

            set 
            {
                this.health = value;
                this.OnHealthChanged?.Invoke(this, this.health);
            } 
        }

        public event EventHandler<int> OnHealthChanged;
        //Event is property of ty[e event
    }
}
