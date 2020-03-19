using System;
using System.Collections.Generic;

namespace PokerWorld.Data
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public List<Player> Players { get; set; }
    }
}
