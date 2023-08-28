using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class Perception : PrimaryStat
    {
        public Perception(int level = 5) : base()
        {
            Name = "Perception";
            Description = "Your ability to sense the physical world.";
            StatValue = GeneratePrimaryStatValue(level);
        }
    }
}
