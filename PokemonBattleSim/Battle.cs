namespace PokemonBattleSim
{
    class Battle
    {
        public static Trainer battle(List<Trainer> trainers) {
            Random rnd = new Random();
            List<Pokemon> activePokemon = [];
            int round = 1;
            int winner = 2;

            while (true) {
                foreach (Trainer trainer in trainers) {
                    int trainerIndex = trainers.IndexOf(trainer);
                    if (winner != trainerIndex) {
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
                    winner = 0;
                } else if (activePokemon[1].strength == activePokemon[0].weakness) {
                    activePokemon.RemoveAt(0);
                    winner = 1;
                } else {
                    if (round == 1) {
                        activePokemon.Clear();
                    } else {
                        activePokemon.RemoveAt(winner);                        
                    }
                }

                if (trainers[0].GetBelt().Count == 0) {
                    return trainers[0];
                } else if (trainers[1].GetBelt().Count == 0) {
                    return trainers[1];
                }

                round++;
            }

        }
    }
}