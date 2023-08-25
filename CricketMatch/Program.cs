using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CricketMatch
{
    internal class Program
    {
        static int NoOfWicket = 2;
        static void Main(string[] args)
        {
            Team bangladesh = new Team("Bangladesh", "BD");
            Team pakistan = new Team("Pakistan", "PK");
            int noOfOver = 0;
            string tossWiner = string.Empty;
            //Team england = new Team("England","EG");

            bangladesh.SetPlayers(GetPlayersFromInput(bangladesh.GetCode()));

            pakistan.SetPlayers(GetPlayersFromInput(pakistan.GetCode()));

            MatchInfo matchInfo = new MatchInfo();
            Console.WriteLine("Enter match title");
            matchInfo.Title = Console.ReadLine();
            matchInfo.TeamOne = bangladesh;
            matchInfo.TeamTwo = pakistan;

            Console.WriteLine("Enter number of overs per innings");
            noOfOver = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the toss winer team code");
            tossWiner = Console.ReadLine();


            Console.WriteLine("Player List");

            foreach (Player player in matchInfo.TeamOne.GetPlayers())
            {
                Console.WriteLine($"Id: {player.GetId()} ---- Name: {player.GetName()}");
            }

            foreach (Player player in matchInfo.TeamTwo.GetPlayers())
            {
                Console.WriteLine($"Id: {player.GetId()} ---- Name: {player.GetName()}");
            }

            Console.WriteLine("Enter openning batsman id");

            int stricker = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter non stricker batsman id");
            int nonStricker = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bowler id");
            int bowlerId = Convert.ToInt32(Console.ReadLine());

            for (int over = 1; over <= noOfOver; over++)
            {
                OverInfo overInfo = new OverInfo();

                int runInOver = 0;
                int wicketInOver = 0;
                for (int ball = 1; ball < overInfo.TotalBall; ball++)
                {
                    Console.WriteLine($"Enter run for ball: {ball}");
                    int run = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter wicket for ball: {ball}");
                    int wicket = Convert.ToInt32(Console.ReadLine());
                    matchInfo.TeamOne.RunInMatch += run;
                    matchInfo.TeamOne.WicketInMatch += wicket;
                    runInOver += run;
                    wicketInOver += wicket;

                    if (matchInfo.TeamOne.WicketInMatch >= (NoOfWicket-1))
                    {
                        break;
                    }
                }

                Console.WriteLine($"Over {over}: {runInOver} Runs, {wicketInOver} Wickets");
                matchInfo.TeamOne.OverInfos.Add(overInfo);

                if (matchInfo.TeamOne.WicketInMatch >= (NoOfWicket - 1))
                {
                    break;
                }
            }


            for (int over = 1; over <= noOfOver; over++)
            {
                OverInfo overInfo = new OverInfo();

                int runInOver = 0;
                int wicketInOver = 0;
                for (int ball = 1; ball < overInfo.TotalBall; ball++)
                {
                    Console.WriteLine($"Enter run for ball: {ball}");
                    int run = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter wicket for ball: {ball}");
                    int wicket = Convert.ToInt32(Console.ReadLine());
                    matchInfo.TeamTwo.RunInMatch += run;
                    matchInfo.TeamTwo.WicketInMatch += wicket;
                    runInOver += run;
                    wicketInOver += wicket;

                    if (matchInfo.TeamTwo.WicketInMatch >= (NoOfWicket - 1))
                    {
                        break;
                    }
                }

                Console.WriteLine($"Over {over}: {runInOver} Runs, {wicketInOver} Wickets");
                matchInfo.TeamTwo.OverInfos.Add(overInfo);

                if (matchInfo.TeamTwo.WicketInMatch >= (NoOfWicket - 1))
                {
                    break;
                }
            }

            Console.WriteLine($"{matchInfo.TeamOne.RunInMatch}/{matchInfo.TeamOne.WicketInMatch}");
            Console.WriteLine($"{matchInfo.TeamTwo.RunInMatch}/{matchInfo.TeamTwo.WicketInMatch}");

            if(matchInfo.TeamOne.RunInMatch > matchInfo.TeamTwo.RunInMatch)
            {
                Console.WriteLine($"Winner : {matchInfo.TeamOne.GetName()}");
            }
            else
            {
                Console.WriteLine($"Winner : {matchInfo.TeamTwo.GetName()}");
            }
        }


        static List<Player> GetPlayersFromInput(string teacmCode)
        {
            Console.WriteLine($"Enter player list for {teacmCode} team:");

            List<Player> players = new List<Player>();

            for (int id = 1; id <= NoOfWicket; id++)
            {
                Console.WriteLine("Player name:");
                string name = Console.ReadLine();
                Player player = new Player(id, name);
                Console.WriteLine("Playing Role:");
                player.SetRole(Console.ReadLine());
                Console.WriteLine("Total Previous Match:");
                player.SetMatch(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Total Previous Runs:");
                player.SetTotalRun(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Total Previous Wickets:");
                player.SetTotalWicket(Convert.ToInt32(Console.ReadLine()));

                players.Add(player);
            }

            return players;
        }
    }
}