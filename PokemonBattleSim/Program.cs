﻿namespace PokemonBattleSim
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                List<Trainer> trainers = new List<Trainer>();

                for (int x = 0; x < 2; x++){
                    List<Pokeball> Belt = [
                        new Pokeball(new Charmander($"Charmander{x}{1}", "Fire", "Water")),
                        new Pokeball(new Charmander($"Charmander{x}{2}", "Fire", "Water")),
                        new Pokeball(new Squirtle($"Squirtle{x}{1}", "Water", "Leaf")),
                        new Pokeball(new Squirtle($"Squirtle{x}{2}", "Water", "Leaf")),
                        new Pokeball(new Bulbasaur($"Bulbasaur{x}{1}", "Grass", "Fire")),
                        new Pokeball(new Bulbasaur($"Bulbasaur{x}{2}", "Grass", "Fire")),
                    ];

                    Console.WriteLine($"Hoe moet trainer {x+1} heten?");
                    string? trainerName = Console.ReadLine();
                    
                    Trainer trainer = new Trainer(trainerName!, Belt);
                    trainers.Add(trainer);
                }

                for (int x = 0; x < trainers[0].GetBelt().Count; x++)
                {
                    trainers[0].ThrowPokeball(x);
                    trainers[1].ThrowPokeball(x);
                    trainers[0].ReturnPokemon(x);
                    trainers[1].ReturnPokemon(x);
                }

                Console.Write("Wil je het programma afsluiten? [Y]: ");
                string? input = Console.ReadLine();

                if ((input == "Y") || (input == "y"))
                {
                    running = false;
                }
            }
        }

    }
}