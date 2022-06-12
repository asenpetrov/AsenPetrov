using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //Problem description:

            //Define a class Trainer and a class Pokemon. 
            //Trainers have:
            //•	Name
            //•	Number of badges
            //•	A collection of pokemon
            //Pokemon have:
            //•	Name
            //•	Element
            //•	Health
            //All values are mandatory.Every Trainer starts with 0 badges.
            //You will be receiving lines until you receive the command "Tournament". Each line will carry information about a pokemon and the trainer who caught it in the format:

            //TrainerName is the name of the Trainer who caught the pokemon.Trainers' names are unique.
            //After receiving the command "Tournament", you will start receiving commands until the "End" command is received.They can contain one of the following:
            //•	"Fire"
            //•	"Water"
            //•	"Electricity"
            //For every command, you must check if a trainer has at least 1 pokemon with the given element.If he does, he receives 1 badge.Otherwise, all of his pokemon lose 10 health.If a pokemon falls to 0 or less health, he dies and must be deleted from the trainer's collection. In the end, you should print all of the trainers, sorted by the number of badges they have in descending order (if two trainers have the same amount of badges, they should be sorted by order of appearance in the input) in the format: 
            //"{trainerName} {badges} {numberOfPokemon}"

            //We create out dictionary where we will store our trainers.
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input = Console.ReadLine();
            //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
            while (input != "Tournament")
            {
                //We split the command so we can use each element.
                string[] token = input.Split(" ");
                string trainerName = token[0];
                string pokemonName = token[1];
                string pokemonElement = token[2];
                int pokemonHealth = int.Parse(token[3]);
                int startBadges = 0;

                //We either create a new trainer or add a Pokemon to an existing one.
                if (trainers.ContainsKey(trainerName))
                {
                    Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    trainers[trainerName].Pokemons.Add(currentPokemon);
                }

                else
                {
                    Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    List<Pokemon> currentPokemons = new List<Pokemon>();
                    currentPokemons.Add(currentPokemon);
                    Trainer currentTrainer = new Trainer(trainerName, startBadges, currentPokemons);
                    trainers.Add(trainerName, currentTrainer);
                }
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                //We create a method for each type of command.
                Attack(command, trainers);
                command = Console.ReadLine();
            }

            //We print the results in the desired order.
            foreach (var trainer in trainers.OrderByDescending(a => a.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
        static void Attack(string command, Dictionary<string, Trainer> trainers)
        {
            //For each case, the action below are similar.
            //If element is present, we add a badge to the respective trainer.
            //If element is not present, we took health points from each Pokemon.
            //If a Pokemon's health drops to 0 or below, we remove the Pokemon.
            if (command == "Fire")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(n => n.Element == command))
                    {
                        trainer.Value.Badges++;
                    }

                    else
                    {
                        trainer.Value.Pokemons.ForEach(n => n.Health -= 10);
                        trainer.Value.Pokemons.RemoveAll(h => h.Health <= 0);
                    }
                }
            }
            else if (command == "Water")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(n => n.Element == command))
                    {
                        trainer.Value.Badges++;
                    }

                    else
                    {
                        trainer.Value.Pokemons.ForEach(n => n.Health -= 10);
                        trainer.Value.Pokemons.RemoveAll(h => h.Health <= 0);
                    }
                }
            }
            else if (command == "Electricity")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(n => n.Element == command))
                    {
                        trainer.Value.Badges++;
                    }

                    else
                    {
                        trainer.Value.Pokemons.ForEach(n => n.Health -= 10);
                        trainer.Value.Pokemons.RemoveAll(h => h.Health <= 0);
                    }
                }
            }
        }
    }
}
