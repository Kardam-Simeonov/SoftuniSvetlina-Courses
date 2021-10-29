using System.Collections.Generic;

namespace Games
{
    public class Squad
    {
        public string SquadName { get; set; }
        public List<string> PlayerList { get; set; }

        public Squad(string firstMember, string squadName)
        {
            SquadName = squadName;
            PlayerList = new List<string>();
            PlayerList.Add(firstMember);
        }
    }
}