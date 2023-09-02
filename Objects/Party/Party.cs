using System;
using System.Collections.Generic;
using System.Text;

namespace The_Waste_Land.Objects.Party
{
    public class Party
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

        public void PrintSimplePartyCharacterSheets()
        {
            foreach (var partyMember in PartyMembers)
            {
                partyMember.PrintSimpleCharacterSheet();
            }
        }

        public bool isDead()
        {
            foreach (var partyMember in PartyMembers)
            {
                if (partyMember.SecondaryStats.HitPoints.StatValue > 0) return false;
            }

            return true;
        }
    }
}
