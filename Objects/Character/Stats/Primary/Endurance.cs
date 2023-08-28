using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class Endurance : PrimaryStat
    {
        public Endurance(int level = 5) : base()
        {
            Name = "Endurance";
            Description = "Physical fitness, wellness, and constitution.";
            StatValue = GeneratePrimaryStatValue(level);
        }
    }
}
