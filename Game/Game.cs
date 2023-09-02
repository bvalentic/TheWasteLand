using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character;
using The_Waste_Land.Objects.Character.Classes.EnemyClass.cs;
using The_Waste_Land.Objects.Character.Classes.PartyClass.cs;
using The_Waste_Land.Objects.Character.Equipment.Weapons;
using The_Waste_Land.Objects.Party;

namespace The_Waste_Land.Game
{
    public static class Game
    {
        public static void NewGame()
        {
            Console.WriteLine("The Waste Land\nWelcome! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}! Generating new character. . .");

            Character PlayerCharacter = new PartyMember(name, 5);
            PlayerCharacter.CharacterClass = new Squire();
            MeleeWeapon shortSword = new MeleeWeapon(5, 10, Enums.Rating.Good, 2.0, 1.0, 5);
            PlayerCharacter.EquippedItems.Weapon = shortSword;
            var playerParty = new PlayerParty();
            playerParty.PartyMembers.Add(PlayerCharacter);

            Console.WriteLine("\nParty:\n");

            PlayerCharacter.PrintCharacterSheet();

            // TODO: Generate 3 Lv.1 bandits, fight Roland, win rewards; repeat

            Console.WriteLine("Ready to begin? (y/n)");
            var key = Console.ReadLine();

            if (key == "y")
            {
                Console.WriteLine("Okay! Let's start!");

                BeginSimpleLoop(playerParty);
            }
            else
            {
                Console.WriteLine("Okay then, see you later! \n\n **Press any key to exit**");
            }
            Console.ReadKey();
        }

        public static void BeginSimpleLoop(PlayerParty playerParty)
        {
            Console.WriteLine("\nBeginning Simple Loop. . .\n");

            var enemyParty = CreateSimpleBanditParty();

            enemyParty.PrintSimplePartyCharacterSheets();

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

            MeleeWeapon dagger = new MeleeWeapon(1, 2, Enums.Rating.Poor, 1.0, 1.0, 1);
            bandit1.EquippedItems.Weapon = dagger;
            bandit2.EquippedItems.Weapon = dagger;
            bandit3.EquippedItems.Weapon = dagger;

            var enemyParty = new EnemyParty();
            enemyParty.PartyMembers.Add(bandit1);
            enemyParty.PartyMembers.Add(bandit2);
            enemyParty.PartyMembers.Add(bandit3);

            return enemyParty;
        }

        public static void GameOver()
        {
            Console.WriteLine("You died! Game over, man!");
            Console.WriteLine("Play again? (y/n)");
            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                Console.WriteLine("Okay! One more time!");

                NewGame();
            }
            else
            {
                Console.WriteLine("Okay then, see you later! \n\n **Press any key to exit**");
                Console.ReadKey();
            }
        }
    }
}
