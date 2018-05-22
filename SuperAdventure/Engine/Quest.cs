﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    public class Quest
    {
        // These are the properties of the Quest class
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

		public Quest(int id, string name, string description,
		             int rewardExperiencePoints, int rewardGold)
		{
			ID = id;
			Name = name;
			Description = description;
			RewardExperiencePoints = rewardExperiencePoints;
			RewardGold = rewardGold;
		}
    }
}
