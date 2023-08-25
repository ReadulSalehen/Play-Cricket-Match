using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketMatch
{
    public class MatchInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Team TeamOne { get; set; }
        public Team TeamTwo { get; set; }
    }
}
