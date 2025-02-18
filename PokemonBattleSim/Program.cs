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
                        new Pokeball(new Squirtle($"Squirtle{x}{1}", "Water", "Grass")),
                        new Pokeball(new Squirtle($"Squirtle{x}{2}", "Water", "Grass")),
                        new Pokeball(new Bulbasaur($"Bulbasaur{x}{1}", "Grass", "Fire")),
                        new Pokeball(new Bulbasaur($"Bulbasaur{x}{2}", "Grass", "Fire")),
                    ];

                    Console.WriteLine($"Hoe moet trainer {x+1} heten?");
                    string? trainerName = Console.ReadLine();

                    Trainer trainer = new Trainer(trainerName!, Belt);
                    trainers.Add(trainer);
                }

                Arena arena = new Arena(trainers);

                Console.WriteLine($"De winnaar is: {arena.StartBattle().GetName()}");
                running = false;
            }
        }

    }
}