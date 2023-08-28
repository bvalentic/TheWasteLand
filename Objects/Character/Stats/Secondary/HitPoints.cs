using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public class HitPoints : SecondaryStat
    {
        public HitPoints(Endurance endurance)
        {
            StatValue = CalculateHitPoints(endurance);
        }

        public double CalculateHitPoints(Endurance endurance)
        {
            var value = endurance.StatValue * 4.0;

            return value;
        }

        public double LevelUpHitPoints(Endurance endurance)
        {
            StatValue += endurance.StatValue;

            return StatValue;
        }
    }
}
