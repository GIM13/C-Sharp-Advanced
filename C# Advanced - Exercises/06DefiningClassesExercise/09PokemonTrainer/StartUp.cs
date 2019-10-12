using System;
using System.Linq;
using System.Collections.Generic;

namespace _09PokemonTrainer
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var trainers = new HashSet<Trainer>();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                bool isThereACoach = false;

                foreach (var nameTrainer in trainers)
                {
                    if (nameTrainer.Name == trainerName)
                    {
                        nameTrainer.Pokemons.Add(pokemon);

                        isThereACoach = true;
                    }
                }

                if (isThereACoach == false)
                {
                    var pokemons = new List<Pokemon>();
                    pokemons.Add(pokemon);

                    var trainer = new Trainer(trainerName, 0, pokemons);
                    trainers.Add(trainer);
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string commandElement = Console.ReadLine();

            while (commandElement != "End")
            {
                foreach (var nameTrainer in trainers)
                {
                    if (nameTrainer.Pokemons.Any(p => p.Element == commandElement))
                    {
                        nameTrainer.Badges++;
                    }
                    else
                    {
                        nameTrainer.Pokemons.Select(p => p.Health = p.Health - 10).ToList();

                        nameTrainer.Pokemons.RemoveAll(p => p.Health < 1);
                    }
                }

                commandElement = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(tr => tr.Badges).ToHashSet();

            foreach (var item in trainers)
            {
                Console.WriteLine($"{item.Name} {item.Badges} {item.Pokemons.Count}");
            }
        }
    }
}
