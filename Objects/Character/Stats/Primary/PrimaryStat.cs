using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class PrimaryStat : StatBase
    {
        public int StatValue { get; set; }

        public PrimaryStat(int level = 5)
        {
            StatValue = GeneratePrimaryStatValue(level);
        }

        // Roll {level}d4, return sum as stat value (result is between 4-20)
        public int GeneratePrimaryStatValue(int numDice = 5)
        {
            var rng = new Random();
            int[] statList = new int[numDice];
            int i = 0;
            int highRoll = 4;

            while (i < statList.Length)
            {
                var roll = rng.Next(1, highRoll + 1); // +1 because Next() doesn't include upper bound
                statList[i] = roll;
                i++;
            }

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
