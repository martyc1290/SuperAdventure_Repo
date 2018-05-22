using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    public class Location
    {
        // These are the properties of the Location class
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

		public Item ItemRequiredToEnter { get; set; }
		public Quest QuestAvailableHere { get; set; }
		public Monster MonsterLivingHere { get; set; }
		public Location LocationToNorth { get; set; }
		public Location LocationToEast { get; set; }
		public Location LocationToSouth { get; set; }
		public Location LocationToWest { get; set; }

        // This is a constructor
        // It is public to see it anywhere in the solution, has a name of the class, and 3 parameters
        public Location(int id, string name, string description, Item itemRequiredToEnter = null,
		                Quest questAvailableHere = null, Monster monsterLivingHere = null)
		{
            // Properties/Variable = Parameters
			ID = id;
			Name = name;
			Description = description;
			ItemRequiredToEnter = itemRequiredToEnter;
			QuestAvailableHere = questAvailableHere;
			MonsterLivingHere = monsterLivingHere;
		}
    }
}
