using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public class DodgeChance : SecondaryStat
    {
        
        public DodgeChance(PrimaryStats primaryStats)
        {
            StatValue = CalculateDodgeChance(primaryStats);
        }

        public double CalculateDodgeChance(PrimaryStats primaryStats)
        {
            double dexValue = primaryStats.Dexterity.StatValue + primaryStats.Dexterity.StatValue % 3;
            double perValue = primaryStats.Perception.StatValue + primaryStats.Perception.StatValue % 3;
            double value = Math.Pow((dexValue + perValue) / 75, 2);

            return Math.Round(value, 4);
        }

        public override string ToString()
        {
            return Math.Round(base.StatValue * 100, 2).ToString() + "%";
        }
    }
}
