using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Enums;
using The_Waste_Land.Objects.Character;
using The_Waste_Land.Objects.Party;

namespace The_Waste_Land.Game.Combat
{
    public class CombatEngine
    {
        public PlayerParty PlayerParty;
        public EnemyParty EnemyParty;
        public bool fighting;
        public int TotalNumCharacters;

        public List<CombatQueueObject> CombatQueue;

        public double BattleCounter;
        public double tick;

        public CombatEngine(PlayerParty playerParty, EnemyParty enemyParty)
        {
            PlayerParty = playerParty;
            EnemyParty = enemyParty;
            TotalNumCharacters = PlayerParty.PartyMembers.Count + EnemyParty.PartyMembers.Count;
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

                BattleCounter = Math.Round(BattleCounter + tick, 2);
            }
        }

        public void Setup()
        {
            fighting = true;
            BattleCounter = 0.00;
            tick = 0.01;
            TotalNumCharacters = PlayerParty.PartyMembers.Count + EnemyParty.PartyMembers.Count;
            CombatQueue = new List<CombatQueueObject>();
            SetupCombatQueue();

            foreach (var item in CombatQueue)
            {
                item.Action = Actions.Attack; // hard-code to always attack
            }
        }

        public void SetupCombatQueue()
        {
            AddPartyToCombatQueue(PlayerParty, true);
            AddPartyToCombatQueue(EnemyParty, false);
        }

        public void AddPartyToCombatQueue(Party party, bool isPlayerControlled)
        {
            // loop through party, adding characters & ticks to combat queue
            for (int i = 0; i < party.PartyMembers.Count; i++)
            {
                var character = party.PartyMembers[i];
                double modifiedAttackTime = SetNextActionTime(character);
                double characterQueuedTime = BattleCounter + modifiedAttackTime;

                CombatQueueObject queueObject = new CombatQueueObject(character, null, characterQueuedTime, Actions.Attack, isPlayerControlled);
                CombatQueue.Add(queueObject);
            }
        }

        public double SetNextActionTime(Character character)
        {
            double modifiedAttackTime = 0;

            if (character.EquippedItems.Weapon.RecoverType == "recover") // melee weapon
            {
                modifiedAttackTime = character.EquippedItems.Weapon.AttackTime * character.SecondaryStats.MeleeAttackTimeModifier.StatValue;
            }

            return Math.Round(modifiedAttackTime + BattleCounter, 2);
        }

        public void CombatLoop()
        {
            // check if action is happening this tick
            // if so, attack, calculate damage, set next tick
            for (int i = 0; i < TotalNumCharacters; i++)
            {
                if (CombatQueue[i].Character.Alive)
                {
                    if (CombatQueue[i].Tick == BattleCounter)
                    {
                        Character attacker = CombatQueue[i].Character;
                        Character target = CombatQueue[i].Target;
                        Actions action = CombatQueue[i].Action;
                        bool isPlayerControlled = CombatQueue[i].isPlayerControlled;

                        if (action == Actions.Attack)
                        {
                            while (target == null || !target.Alive) // set target if none or dead; repeat if new selection is also dead
                            {
                                if (isPlayerControlled)
                                {
                                    var index = new Random().Next(0, EnemyParty.PartyMembers.Count);
                                    target = EnemyParty.PartyMembers[index];
                                }
                                else
                                {
                                    var index = new Random().Next(0, PlayerParty.PartyMembers.Count);
                                    target = PlayerParty.PartyMembers[index];
                                }
                                CombatQueue[i].Target = target;
                            }
                            Attack(attacker, target);
                            var nextAttackTime = SetNextActionTime(attacker);
                            CombatQueue[i].Tick = nextAttackTime;
                        }
                    }
                }
            }
        }

        public void Attack(Character attacker, Character defender)
        {
            var attackDamage = Math.Round(attacker.EquippedItems.Weapon.Damage * attacker.SecondaryStats.DamageMelee.StatValue, 2);
            Console.WriteLine($"{attacker.Name} attacks {defender.Name} for {attackDamage} damage!");
            var newHitPoints = Math.Round(defender.SecondaryStats.HitPoints.StatValue - attackDamage, 2);
            defender.SecondaryStats.HitPoints.StatValue = newHitPoints;
            Console.WriteLine($"{defender.Name} has {defender.SecondaryStats.HitPoints.StatValue} hit points remaining!");
            if (defender.IsDead())
            {
                Console.WriteLine($"{defender.Name} dies!");
                defender.Alive = false;
            }
            Console.WriteLine("(Press any key to continue.)");
            Console.ReadKey();
        }

        public void Rewards()
        {
            fighting = false;
            Console.WriteLine("You won! Rewards time!");
            // generate loot based on avg enemy level
        }

        public void PartyDeath()
        {
            // show game over, return to start screen
            fighting = false;
            
            Game.GameOver();
        }
    }
}
