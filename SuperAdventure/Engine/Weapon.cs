using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    // Weapon has a base class of Item, meaning it is a child class of Item
    public class Weapon : Item
    {
        // These are the properties of the Weapon class
        // All public properties and methods from the Item class now automatically show up in Weapon class
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        // This is the constructor of the Weapon class
		public Weapon(int id, string name, string namePlural, int minimumDamage,
		              int maximumDamage): base(id, name, namePlural)
		{
			MinimumDamage = minimumDamage;
			MaximumDamage = maximumDamage;
		}
    }
}
