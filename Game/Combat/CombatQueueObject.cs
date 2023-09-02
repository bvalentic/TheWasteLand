using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Enums;
using The_Waste_Land.Objects.Character;

namespace The_Waste_Land.Game.Combat
{
    public class CombatQueueObject
    {
        public Character Character;
        public Character Target;
        public double Tick;
        public Actions Action;
        public bool isPlayerControlled;
        public CombatQueueObject(Character character, Character target, double tick, Actions action, bool isPlayerControlled)
        {
            Character = character;
            Target = target;
            Tick = tick;
            Action = action;
            this.isPlayerControlled = isPlayerControlled;
        }
    }
}
