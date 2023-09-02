using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public class MeleeAttackTimeModifier : SecondaryStat
    {

        public MeleeAttackTimeModifier(PrimaryStats primaryStats)
        {
            StatValue = CalculateMeleeAttackTimeModifier(primaryStats);
        }

        // returns a number between 0-1, the attack time modifier
        public double CalculateMeleeAttackTimeModifier(PrimaryStats primaryStats)
        {
            double strMod = primaryStats.Strength.StatValue + primaryStats.Strength.StatValue % 3;
            double endMod = primaryStats.Endurance.StatValue + primaryStats.Endurance.StatValue % 3;
            double modifier = strMod + endMod * 0.5;

            double value = 100 - Math.Pow(modifier, 0.5);

            return Math.Round(value/100, 2);
        }

        public override string ToString()
        {
            return (StatValue * 100).ToString() + "%";
        }
    }
}
