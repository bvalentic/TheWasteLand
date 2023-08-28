using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Primary
{
    public class Intelligence : PrimaryStat
    {
        public Intelligence(int level = 5)
        {
            Name = "Intelligence";
            Description = "Knowledge, critical thinking, and its applications.";
            StatValue = GeneratePrimaryStatValue(level);
        }
    }
}
