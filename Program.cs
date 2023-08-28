using System;
using The_Waste_Land.Game;
using The_Waste_Land.Objects.Character;
using The_Waste_Land.Objects.Character.Classes.PartyClass.cs;

namespace The_Waste_Land
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame();
        }

        static void RunGame()
        {
            Console.WriteLine("The Waste Land");

            Character Roland = new PartyMember("Roland", 5);
            Roland.CharacterClass = new Squire();

            Console.WriteLine("\nParty:\n");

            Roland.PrintCharacterSheet();

            // TODO: Generate 3 Lv.1 bandits, fight Roland, win rewards; continue

            Console.WriteLine("Ready to begin? (y/n) ");
            var key = Console.ReadLine();

            if (key == "y")
            {
                Console.WriteLine("Okay! Let's start!");

                Game.Game.BeginSimpleLoop();
            }
            else
            {
                Console.WriteLine("Okay then, see you later! \n\n **Press any key to exit**");
                Console.ReadKey();
            }
        }
    }
}
