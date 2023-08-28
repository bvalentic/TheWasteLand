using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public class DamageMelee : SecondaryStat
    {
        public DamageMelee(PrimaryStats primaryStats)
        {
            StatValue = CalculateDamageMelee(primaryStats);
        }

        public double CalculateDamageMelee(PrimaryStats primaryStats)
        {
            double value = primaryStats.Strength.StatValue + primaryStats.Perception.StatValue;
            double modifier = value / 100 + 1;

            return Math.Round(modifier, 3);
        }
    }
}
