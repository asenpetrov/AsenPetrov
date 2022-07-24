using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace FootballTeamGenerator
{
    public class Team
    {
        //We initiate fields so we can use proper encapsulation.
        private string name;
        private readonly List<Player> players;

        //We create 2 constructors.
        private Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name)
            : this()
        {
            this.Name = name;
        }
       
        //We make the proper validation in our setter.
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (this.players.Count > 0)
                {
                    return (int)Math.Round(this.players.Average(p => p.OverallSkills), 0);
                }
                return 0;
            }
        }  

        //We create 2 methods for Adding and Removing players from the team with the needed validations before that.
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player playerToDelete = this.players.FirstOrDefault(p => p.Name == playerName);
            if (playerToDelete == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.Remove(playerToDelete);
        }
    }
}
