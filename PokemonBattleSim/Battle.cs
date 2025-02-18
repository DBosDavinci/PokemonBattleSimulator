namespace PokemonBattleSim
{
    class Battle
    {
        List<Trainer> trainers;
        int round = 1;

        public Battle(List<Trainer> trainers)
        {
            this.trainers = trainers;
        }

        public int GetRounds()
        {
            return round;
        }

        public Trainer NewBattle() 
        {
            Random rnd = new Random();
            List<Pokemon> activePokemon = [];
            int roundWinner = 2;

            while (true) {
                foreach (Trainer trainer in trainers) {
                    int trainerIndex = trainers.IndexOf(trainer);
                    if (roundWinner != trainerIndex) {
                        List<Pokeball> belt = trainer.GetBelt();
                        int randomNumber = rnd.Next(belt.Count-1);

                        if (activePokemon.Count == 2) {
                            activePokemon[trainerIndex] = trainer.ThrowPokeball(randomNumber);
                        } else {
                            activePokemon.Add(trainer.ThrowPokeball(randomNumber));
                        }

                        belt.RemoveAt(randomNumber);
                        trainer.SetBelt(belt);
                    }
                }

                if (activePokemon[0].strength == activePokemon[1].weakness) {
                    activePokemon.RemoveAt(1);
                    roundWinner = 0;
                    Console.WriteLine($"Ronde is gewonnen door: {trainers[0].GetName()}");
                } else if (activePokemon[1].strength == activePokemon[0].weakness) {
                    activePokemon.RemoveAt(0);
                    roundWinner = 1;
                    Console.WriteLine($"Ronde is gewonnen door: {trainers[1].GetName()}");
                } else {
                    if (round == 1) {
                        activePokemon.Clear();
                    } else {
                        activePokemon.RemoveAt(roundWinner);                        
                    }
                    Console.WriteLine($"Ronde was een draw");
                }

                if (trainers[0].GetBelt().Count == 0 && roundWinner != 0) {
                    return trainers[1];
                } else if (trainers[1].GetBelt().Count == 0 && roundWinner != 1) {
                    return trainers[0];
                }

                round++;
            }

        }
    }
}