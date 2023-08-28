using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class Dexterity : PrimaryStat
    {
        public Dexterity(int level = 5) : base()
        {
            Name = "Dexterity";
            Description = "Your body's ability to move and adjust itself. Dodging and reloading.";
            StatValue = GeneratePrimaryStatValue(level);
        }
    }
}
