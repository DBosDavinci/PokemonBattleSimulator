namespace PokemonBattleSim
{
    sealed class Pokeball
    {
        readonly Pokemon pokemon;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public Pokemon Open()
        {
            Console.WriteLine("De Pokeball opent.");
            Console.WriteLine(pokemon.BattleCry());
            return pokemon;
        }

        public void Close()
        {
            Console.WriteLine("De Pokeball sluit.");
        }
    }
}