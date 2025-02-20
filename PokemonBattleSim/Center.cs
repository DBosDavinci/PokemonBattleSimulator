namespace PokemonBattleSim
{
    class Center : Place
    {
        Nurse nurse;
        HealingStation healingStation;

        public Center(Nurse nurse)
        {
            this.nurse = nurse;
            healingStation = new HealingStation(nurse);
        }

        public void RevivePokemon(Trainer trainer)
        {
            List<Pokeball> belt = trainer.GetBelt();

            healingStation.HealPokemon(belt);

            trainer.SetBelt(belt);
        }
    }
}