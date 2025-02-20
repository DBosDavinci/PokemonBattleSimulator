namespace PokemonBattleSim
{
    class HealingStation
    {
        Nurse nurse;

        public HealingStation(Nurse nurse)
        {
            this.nurse = nurse;
        }

        public List<Pokeball> HealPokemon(List<Pokeball> belt)
        {
            return belt;
        }
    }
}