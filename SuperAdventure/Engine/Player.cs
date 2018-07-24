using System;
using System.Collections.Generic; // This allows program will find everything it needs to work with collections
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

        public Location CurrentLocation { get; set; }

        // These are two properties that can hold lists containing InventoryItem and PlayerQuests objects
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        // This is the constructor of the Player class
		public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints,
		              int level) : base(currentHitPoints, maximumHitPoints)
		{
			Gold = gold;
			ExperiencePoints = experiencePoints;
			Level = level;
            // The following two lines set the value of the new properties to empty lists, allowing items to be added to them later
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
		}
    }
}
