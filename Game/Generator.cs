using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Enums;
using The_Waste_Land.Lists;
using The_Waste_Land.Objects.Character;
using The_Waste_Land.Objects.Character.Classes;
using The_Waste_Land.Objects.Character.Classes.EnemyClass.cs;

namespace The_Waste_Land.Game
{
    static class Generator
    {
        public static string[] StarterClasses = new ClassLists().StarterClasses;
        public static Character GenerateCharacter(string name, int level)
        {
            Character character = new Character(name, level);

            return character;
        }

        public static Character GenerateCharacter(string name, int level, CharacterClass characterClass)
        {
            Character character = new Character(name, level);
            character.CharacterClass = characterClass;

            return character;
        }

        public static Enemy GenerateEnemy(string name, int level, string className)
        {
            
            Enemy enemy = new Enemy(name, level);

            foreach (var starterClass in StarterClasses)
            {
                // somehow set enemy class to that type
            }

            return enemy;
        }
    }
}
