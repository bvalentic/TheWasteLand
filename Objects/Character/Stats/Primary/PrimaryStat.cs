using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class PrimaryStat : StatBase
    {
        public int StatValue { get; set; }

        public PrimaryStat()
        {
            StatValue = GeneratePrimaryStatValue();
        }

        // Roll 5d5, discard lowest, return sum (will be between 4-20) 
        public int GeneratePrimaryStatValue()
        {
            var rng = new Random();
            int[] statList = new int[5];
            int i = 0;
            int lowRoll = 5;
            int lowRollIndex = 0;

            while (i < statList.Length)
            {
                var roll = rng.Next(1, 6);
                statList[i] = roll;
                if (lowRoll > roll)
                {
                    lowRoll = roll;
                    lowRollIndex = i;
                }
                i++;
            }

            statList[lowRollIndex] = 0;
            int total = 0;

            foreach (var item in statList)
            {
                total += item;
            }
            return total;
        }

        public override string ToString()
        {
            return StatValue.ToString();
        }
    }
}
