using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    // HealingPotion has a base class of Item, meaning it is a child class of Item
    public class HealingPotion : Item
    {
        // These are the properties of the HealingPotion class
        // All public properties and methods from the Item class now automatically show up in HealingPotion class
        public int AmountToHeal { get; set; }

		// This is the constructor for the Healing Potion class
        // The second part of this constructor takes values from the parameters in the Healing Potion Class
        // and passes them on to the constructor of the Item class
		public HealingPotion(int id, string name, string namePlural,
		                     int amountToHeal) : base(id, name, namePlural)
		{
			AmountToHeal = amountToHeal;
		}
    }
}
