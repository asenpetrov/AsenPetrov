using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        //We create private fields so we can make validation.
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        //We create a constructor for creating a new instance of a Player.
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance; 
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        //We make the proper validation in our setters.

        public string Name 
        {
            get 
            {
                return name;
            }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Endurance 
        { 
            get 
            {
                return endurance;
            } 
            set
            {
                if (value <0 || value >100)
                {
                    throw new ArgumentException($"{nameof(this.Endurance)} should be between 0 and 100.");

                }
                endurance = value;
            } 
        }
        public int Sprint 
        {
            get
            {
                return sprint;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Sprint)} should be between 0 and 100.");

                }
                sprint = value;
            }
        }
        public int Dribble 
        {
            get
            {
                return dribble;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Dribble)} should be between 0 and 100.");

                }
                dribble = value;
            }
        }
        public int Passing 
        {
            get
            {
                return passing;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Passing)} should be between 0 and 100.");

                }
                passing = value;
            }
        }
        public int Shooting 
        {
            get
            {
                return shooting;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Shooting)} should be between 0 and 100.");

                }
                shooting = value;
            }
        }

        //We calculate the Overall skills for the player based on their primary skills.
        public double OverallSkills => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;

    }
}
