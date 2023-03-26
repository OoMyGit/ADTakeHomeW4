using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTakeHomeW4
{
    public class Team
    {
        string teamname;
        string teamcountry;
        string teamcity;
        public List<Player> Players = new List<Player>();
        public string TeamName
        {
            get { return teamname; }
            set { teamname = value; }
        }
        public string TeamCountry
        {
            get { return teamcountry; }
            set { teamcountry = value; }
        }
        public string TeamCity
        {
            get { return teamcity; }
            set { teamcity = value; }
        }
        public void addingplayer(string name, string num, string pos)
        {
            Player pemain = new Player();
            pemain.PlayerName = name;
            pemain.PlayerNum = num;
            pemain.PlayerPos = pos;
            Players.Add(pemain);
        }
    }
}
