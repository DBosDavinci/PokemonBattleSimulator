﻿namespace PokemonBattleSim
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                List<Pokeball> Belt1 = new List<Pokeball>();
                for (int x = 0; x < 6; x++)
                {
                    Belt1.Add(new Pokeball(new Charmander("f" + x, "Fire", "Water")));
                }
                Console.WriteLine("Hoe moet de eerste trainer heten?");
                string? trainer1Name = Console.ReadLine();
                Trainer trainer1 = new Trainer(trainer1Name, Belt1);


                List<Pokeball> Belt2 = new List<Pokeball>();
                for (int x = 0; x < 6; x++)
                {
                    Belt2.Add(new Pokeball(new Charmander("g" + x, "Fire", "Water")));
                }
                Console.WriteLine("Hoe moet de tweede trainer heten?");
                string? trainer2Name = Console.ReadLine();
                Trainer trainer2 = new Trainer(trainer2Name, Belt2);


                for (int x = 0; x < Belt1.Count; x++)
                {
                    trainer1.ThrowPokeball(x);
                    trainer2.ThrowPokeball(x);
                    trainer1.ReturnPokemon(x);
                    trainer2.ReturnPokemon(x);
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