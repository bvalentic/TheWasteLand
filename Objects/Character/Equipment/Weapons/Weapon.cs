using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Enums;

namespace The_Waste_Land.Objects.Character.Equipment.Weapons
{
    public class Weapon : Equipment
    {
        public double AttackTime;
        public double RecoverTime;
        public string RecoverType; // recover (melee) or reload (ranged)
        public double Damage;
        public Weapon(int level, int value, Rating rating) : base(level, value, rating)
        {

        }
    }
}
