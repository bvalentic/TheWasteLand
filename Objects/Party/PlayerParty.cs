using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Game;

namespace The_Waste_Land.Objects.Party
{
    internal class PlayerParty : Party
    {
        public PlayerParty()
        {

        }

        public void Fight (EnemyParty enemyParty)
        {
            Console.WriteLine("Your party encounters enemies!");

            CombatEngine.RunFullCombatEncounter(this, enemyParty);
        }

        public bool isDead()
        {
            foreach (var partyMember in PartyMembers)
            {
                if (partyMember.SecondaryStats.HitPoints.StatValue > 0) return false;
            }

            return true;
        }
    }
}
