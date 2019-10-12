using System.Collections.Generic;

namespace _09PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int badges, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}
