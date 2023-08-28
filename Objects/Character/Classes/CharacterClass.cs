using The_Waste_Land.Objects.Character.Stats.Primary;

namespace The_Waste_Land.Objects.Character.Classes
{
    public class CharacterClass
    {
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int Level { get; set; }
        public CharacterClass(int level = 1)
        {
            Level = level;
        }
    }
}