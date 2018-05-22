using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	// Public scope visible throughout whole solution
    // Boss has a base class of LivingCreature, meaning it is a child class of LivingCreature

    // Boss class is my own inserted class meant to test my understanding of the textbook
    // Boss class should closeley resemble Monster, in order to check if it is functioning properly

	public class Boss : LivingCreature
	{
		// These are the properties of the Boss class
        public int ID { get; set; }
        public string Name { get; set; }
        // All public properties and methods from the LivingCreature class now automatically show up in Boss class
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
		public int RewardGold { get; set; }
		public int RewardBossKey { get; set; }  // Boss Key is my own test. Not sure how it will work?

		public Boss(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold,
		            int rewardBossKey, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
		{
			ID = id;
			Name = name;
			MaximumDamage = maximumDamage;
			RewardExperiencePoints = rewardExperiencePoints;
			RewardGold = rewardGold;
			RewardBossKey = rewardBossKey;
		}
    }
}
