namespace PokemonBattleSim
{
    class Arena
    {
        List<Trainer> trainers;
        int totalBattles;
        int totalRounds;

        public Arena(List<Trainer> trainers)
        {
            this.trainers = trainers;
        }

        public Trainer StartBattle()
        {
            Battle battle = new Battle(trainers);
            Trainer winner = battle.NewBattle();
            
            totalBattles++;
            totalRounds += battle.GetRounds();

            return winner;
        }
    }
}