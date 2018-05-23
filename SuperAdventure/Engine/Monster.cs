using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    // Monster has a base class of LivingCreature, meaning it is a child class of LivingCreature
    public class Monster : LivingCreature
    {
        // These are the properties of the Monster class
        public int ID { get; set; }
        public string Name { get; set; }
        // All public properties and methods from the LivingCreature class now automatically show up in Monster class
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

		public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold,
		               int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
		{
			ID = id;
			Name = name;
			MaximumDamage = maximumDamage;
			RewardExperiencePoints = rewardExperiencePoints;
			RewardGold = rewardGold;
            LootTable = new List<LootItem>();
		}
    }
}
