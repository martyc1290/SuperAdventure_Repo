using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    // Player has a base class of LivingCreature, meaning it is a child class of LivingCreature
    public class Player : LivingCreature
    {
        // These are the properties of the Player class
        // All public properties and methods from the LivingCreature class now automatically show up in Player class
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
    }
}
