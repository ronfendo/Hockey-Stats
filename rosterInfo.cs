using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey_Stats
{
    public class rosterInfo
    {
        public List<string> playerName { get; set; }
        public List<int> playerNumber { get; set; }
    }
    public class stats : List<rosterInfo>
    {
        int goals { get; set; }
        int assists { get; set; }
    }
    public class attributeLock
    {
        bool playerInfoLock { get; set; }
    }
}
