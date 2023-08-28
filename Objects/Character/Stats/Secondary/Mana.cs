using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public class Mana : SecondaryStat
    {
        public Mana(PrimaryStats primaryStats)
        {
            StatValue = CalculateMana(primaryStats);
        }

        public double CalculateMana(PrimaryStats primaryStats)
        {
            var intValue = primaryStats.Intelligence.StatValue * 4;
            var wisValue = primaryStats.Wisdom.StatValue * 2;

            return intValue + wisValue;
        }
    }
}
