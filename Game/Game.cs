using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character;
using The_Waste_Land.Objects.Character.Classes.EnemyClass.cs;
using The_Waste_Land.Objects.Character.Classes.PartyClass.cs;
using The_Waste_Land.Objects.Party;

namespace The_Waste_Land.Game
{
    internal static class Game
    {
        public static void RunGame()
        {
            Console.WriteLine("The Waste Land");

            Character Roland = new PartyMember("Roland", 5);
            Roland.CharacterClass = new Squire();

            Console.WriteLine("\nParty:\n");

            Roland.PrintCharacterSheet();

            // TODO: Generate 3 Lv.1 bandits, fight Roland, win rewards; repeat

            Console.WriteLine("Ready to begin? (y/n) ");
            var key = Console.ReadLine();

            if (key == "y")
            {
                Console.WriteLine("Okay! Let's start!");

                BeginSimpleLoop();
            }
            else
            {
                Console.WriteLine("Okay then, see you later! \n\n **Press any key to exit**");
            }
                Console.ReadKey();
        }

        public static void BeginSimpleLoop()
        {
            Console.WriteLine("\nBeginning Simple Loop. . .\n");

            var enemyParty = CreateSimpleBanditParty();
            var playerParty = new PlayerParty();

            enemyParty.PrintPartyCharacterSheets();

            playerParty.Fight(enemyParty);
        }

        private static EnemyParty CreateSimpleBanditParty()
        {
            var bandit1 = new Character("Bandit 1", 1);
            var bandit2 = new Character("Bandit 2", 1);
            var bandit3 = new Character("Bandit 3", 1);
            bandit1.CharacterClass = new Bandit();
            bandit2.CharacterClass = new Bandit();
            bandit3.CharacterClass = new Bandit();

            var enemyParty = new EnemyParty();
            enemyParty.PartyMembers.Add(bandit1);
            enemyParty.PartyMembers.Add(bandit2);
            enemyParty.PartyMembers.Add(bandit3);

            return enemyParty;
        }
    }
}
