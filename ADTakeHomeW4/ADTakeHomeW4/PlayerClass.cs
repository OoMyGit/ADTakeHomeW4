using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTakeHomeW4
{
    public class Player
    {
        string playername;
        string playernum;
        string playerpos;
        public string PlayerName
        {
            get { return playername; }
            set { playername = value; }
        }
        public string PlayerNum
        {
            get { return playernum; }
            set { playernum = value; }
        }
        public string PlayerPos
        {
            get { return playerpos; }
            set { playerpos = value; }
        }
    }
}
