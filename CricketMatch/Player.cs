using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketMatch
{
    public class Player
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Role { get; set; }
        private int Match { get; set; }
        private int TotalRun { get; set; }
        private int TotalWicket { get; set; }
        private int RunInMatch { get; set; }
        private int WicketInMatch { get; set; }
        private List<Player> Wickets { get; set; }
        public List<OverInfo> OverInfos { get; set; }


        public Player()
        {
           
        }
        public Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Wickets = new List<Player>();
        }

        public void SetRole(string role)
        {
            this.Role = role;
        }

        public void SetMatch(int noOfMatch)
        {
            this.Match=noOfMatch;
        }
        public void SetTotalRun(int totalRun)
        {
            this.TotalRun= totalRun;
        }
        public void SetTotalWicket(int totalWicket)
        {
            this.TotalWicket = totalWicket;
        }
        public void SetRunInMatch(int run)
        {
            this.RunInMatch = run;
        }
        public void SetWicketInMatch(int wicket)
        {
            this.WicketInMatch = wicket;
        }
        public void SetWickets(List<Player> players)
        {
            this.Wickets = players;
        }

        public int GetId()
        {
            return this.Id;
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetRole()
        {
          return this.Role;
        }

        public int GetMatch()
        {
            return this.Match;
        }
        public int GetTotalRun()
        {
            return this.TotalRun;
        }
        public int GetTotalWicket()
        {
            return this.TotalWicket;
        }
        public int GetRunInMatch()
        {
            return this.RunInMatch;
        }
        public int GetWicketInMatch()
        {
            return this.WicketInMatch;
        }
        public List<Player> GetWickets()
        {
           return this.Wickets;
        }

    }
}
