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
                        new Pokeball(new Charmander()),
                        new Pokeball(new Charmander()),
                        new Pokeball(new Squirtle()),
                        new Pokeball(new Squirtle()),
                        new Pokeball(new Bulbasaur()),
                        new Pokeball(new Bulbasaur())
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