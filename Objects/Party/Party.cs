using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Party
{
    internal class Party
    {
        public List<Character.Character> PartyMembers;

        public Party()
        {
            PartyMembers = new List<Character.Character>();
        }

        public void PrintPartyCharacterSheets()
        {
            foreach (var partyMember in PartyMembers)
            {
                partyMember.PrintCharacterSheet();
            }
        }
    }
}
