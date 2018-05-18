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
    }
}
