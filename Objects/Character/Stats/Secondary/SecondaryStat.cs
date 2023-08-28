using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public abstract class SecondaryStat : StatBase
    {
        public double StatValue { get; set; }
        public SecondaryStat() 
        {

        }

        public override string ToString()
        {
            return StatValue.ToString();
        }
    }
}
