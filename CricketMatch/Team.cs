using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketMatch
{
    public class Team
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private string Code { get; set; }
        public int RunInMatch { get; set; }
        public int WicketInMatch { get; set; }
        private List<Player> Players { get; set; }
        public List<OverInfo> OverInfos { get; set; }


        public Team()
        {
            
        }

        public Team(string name, string code)
        {
            this.Name = name;
            this.Code = code;
            this.RunInMatch = 0;
            this.WicketInMatch = 0;
            this.Players = new List<Player>();
            this.OverInfos = new List<OverInfo>();
        }

        public void SetPlayers(List<Player> players)
        {
            this.Players = players;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetCode() { 
            return this.Code; 
        }

        public List<Player> GetPlayers()
        {
            return this.Players;
        }
    }
}
