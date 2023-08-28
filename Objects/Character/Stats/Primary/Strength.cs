using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class Strength : PrimaryStat
    {
        public Strength(int level = 5) : base()
        {
            Name = "Strength";
            Description = "The amount of force you can use to manipulate the physical world.";
            StatValue = GeneratePrimaryStatValue(level);
        }
    }
}
