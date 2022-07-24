using System;
using System.Collections.Generic;
namespace FootballTeamGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We create a Dictionary to store our Teams.
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                //Initiate Try/Catch
                try
                {
                    //We receive the input and work on it.
                    string[] token = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                    string commandName = token[0];
                    if (commandName == "Team")
                    {
                        string teamName = token[1];

                        Team currentTeam = new Team(teamName);
                        teams.Add(teamName, currentTeam);
                    }
                    else if (commandName == "Add")
                    {
                        //Add;{TeamName};{PlayerName};{Endurance};{Sprint};{Dribble};{Passing};{Shooting}" 
                        string teamName = token[1];

                        string playerName = token[2];
                        int endurance = int.Parse(token[3]);
                        int sprint = int.Parse(token[4]);
                        int dribble = int.Parse(token[5]);
                        int passing = int.Parse(token[6]);
                        int shooting = int.Parse(token[7]);

                        if (!CheckTeam(teamName, teams))
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            Player currPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            teams[teamName].AddPlayer(currPlayer);
                        }

                    }
                    else if (commandName == "Remove")
                    {
                        string teamName = token[1];

                        string playerToRemove = token[2];
                        teams[teamName].RemovePlayer(playerToRemove);
                    }
                    else if (commandName == "Rating")
                    {
                        string teamName = token[1];

                        if (!CheckTeam(teamName, teams))
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {

                            Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message); ;
                }

            }

            //We create a method to check if a team exists.
            static bool CheckTeam(string teamName, Dictionary<string, Team> teams)
            {
                if (teams.ContainsKey(teamName))
                {
                    return true;
                }
                return false;
            }

        }

    }
}