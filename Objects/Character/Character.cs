using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character.Classes;
using The_Waste_Land.Objects.Character.Effects;
using The_Waste_Land.Objects.Character.Stats.Primary;
using The_Waste_Land.Objects.Character.Stats.Secondary;

namespace The_Waste_Land.Objects.Character
{
    public class Character
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public Status[] StatusEffects { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public PrimaryStats PrimaryStats { get; set; }
        public SecondaryStats SecondaryStats { get; set; }
        public Character(string name, int level)
        {
            Name = name;
            Level = level;
            PrimaryStats = new PrimaryStats(level);
            SecondaryStats = new SecondaryStats(PrimaryStats);
        }
        public Character(string name, int level, CharacterClass characterClass) 
        {
            Name = name;
            Level = level;
            PrimaryStats = new PrimaryStats(level);
            SecondaryStats = new SecondaryStats(PrimaryStats);
            CharacterClass = characterClass;
        }

        public void PrintCharacterSheet()
        {
            string message =
$@"Name: {Name}
Class: {CharacterClass.ClassName}
Level: {Level}
-----
Primary Stats:

Strength: {PrimaryStats.Strength}
Wisdom: {PrimaryStats.Wisdom}
Intelligence: {PrimaryStats.Intelligence}
Perception: {PrimaryStats.Perception}
Endurance: {PrimaryStats.Endurance}
Dexterity: {PrimaryStats.Dexterity}
-----
Secondary Stats:

Hit Points: {SecondaryStats.HitPoints}
Melee Damage: {SecondaryStats.DamageMelee}x
Mana: {SecondaryStats.Mana}
Dodge Chance: {SecondaryStats.DodgeChance}%
-----
";
            Console.WriteLine(message);
        }
    }
}
