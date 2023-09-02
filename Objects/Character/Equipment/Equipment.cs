using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Enums;

namespace The_Waste_Land.Objects.Character.Equipment
{
    public class Equipment
    {
        public string Name;
        public string Description;
        public int Level;
        public int Value;
        public Rating Rating;
        public Equipment(int level, int value, Rating rating)
        {
            Level = level;
            Value = value;
            Rating = rating;
        }
    }
}
