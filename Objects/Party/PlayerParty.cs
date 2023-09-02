using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Game.Combat;

namespace The_Waste_Land.Objects.Party
{
    public class PlayerParty : Party
    {
        public PlayerParty()
        {

        }

        public void Fight (EnemyParty enemyParty)
        {
            Console.WriteLine("Your party encounters enemies!");

            CombatEngine combatEngine = new CombatEngine(this, enemyParty);
            combatEngine.RunFullCombatEncounter();
        }
    }
}
