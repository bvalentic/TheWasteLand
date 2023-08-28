using System.Reflection.Emit;
using System;
using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Stats.Secondary
{
    public class SecondaryStats
    {
        public HitPoints HitPoints { get; set; }
        public DamageMelee DamageMelee { get; set; }
        public Mana Mana { get; set; }
        public DodgeChance DodgeChance { get; set; }
        public PrimaryStats PrimaryStats { get; set; }
        public SecondaryStats(PrimaryStats primaryStats)
        {
            PrimaryStats = primaryStats;
            
            HitPoints = new HitPoints(primaryStats.Endurance);
            DamageMelee = new DamageMelee(primaryStats);
            Mana = new Mana(primaryStats);
            DodgeChance = new DodgeChance(primaryStats);
        }
    }
}