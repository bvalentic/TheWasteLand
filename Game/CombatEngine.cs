using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Party;

namespace The_Waste_Land.Game
{
    public class CombatEngine
    {
        public PlayerParty PlayerParty;
        public EnemyParty EnemyParty;
        public bool fighting;
        public CombatEngine(PlayerParty playerParty, EnemyParty enemyParty)
        {
            PlayerParty = playerParty;
            EnemyParty = enemyParty;
        }
        public void RunFullCombatEncounter()
        {
            Setup();

            
            while (fighting)
            {
                if (PlayerParty.isDead())
                {
                    PartyDeath();
                }
                else if (EnemyParty.isDead())
                {
                    Rewards();
                }
                else
                {
                    CombatLoop(); 
                }
            }
        }

        public void Setup()
        {
            fighting = true;
        }

        public void CombatLoop()
        {

        }

        public void Rewards()
        {

        }

        public void PartyDeath()
        {

        }
    }
}
