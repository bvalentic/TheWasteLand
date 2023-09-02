using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Game.Combat;

namespace The_Waste_Land.Objects.Party
{
    public class EnemyParty : Party
    {
        public EnemyParty()
        {

        }

        public void Fight(PlayerParty playerParty)
        {
            Console.WriteLine("Your party encounters enemies!");

            CombatEngine combatEngine = new CombatEngine(playerParty, this);
            combatEngine.RunFullCombatEncounter();
        }
    }
}
