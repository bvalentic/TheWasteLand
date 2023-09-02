using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Enums;

namespace The_Waste_Land.Objects.Character.Equipment.Weapons
{
    public class MeleeWeapon : Weapon
    {

        public MeleeWeapon(int level, int value, Rating rating, double attackTime, double recoverTime, double damage) : base(level, value, rating)
        {
            AttackTime = attackTime;
            RecoverTime = recoverTime;
            Damage = damage;
            RecoverType = "recover";
        }
    }
}
