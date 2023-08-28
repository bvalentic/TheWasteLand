using System;
using System.Collections.Generic;
using System.Text;
using The_Waste_Land.Objects.Character;

namespace The_Waste_Land.Game
{
    static class Generator
    {

        public static Character GenerateCharacter()
        {
            Character character = new Character("random");
            return character;
        }
    }
}
