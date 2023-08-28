using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class PrimaryStats
    {
        public Strength Strength { get; set; }
        public Wisdom Wisdom { get; set; }
        public Intelligence Intelligence { get; set; }
        public PrimaryStat Perception { get; set; }
        public Endurance Endurance { get; set; } // Constitution?
        public Dexterity Dexterity { get; set; } // Agility?
        // maybes
        public Piety Piety { get; set; }
        public PrimaryStat Charisma { get; set; }
        public PrimaryStat Luck { get; set; }

        public PrimaryStats(int level = 5)
        {
            Strength = new Strength(level);
            Wisdom = new Wisdom(level);
            Intelligence = new Intelligence(level);
            Perception = new Perception(level);
            Endurance = new Endurance(level);
            Dexterity = new Dexterity(level);
        }
    }
}
