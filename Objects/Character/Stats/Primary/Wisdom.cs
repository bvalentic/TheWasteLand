using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class Wisdom : PrimaryStat
    {
        public Wisdom(int level = 5) : base()
        {
            Name = "Wisdom";
            Description = "Willpower, common sense, intuition. Knowing from experience.";
            StatValue = GeneratePrimaryStatValue(level);
        }
    }
}
