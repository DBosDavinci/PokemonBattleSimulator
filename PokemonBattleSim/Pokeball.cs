namespace PokemonBattleSim
{
    class Pokeball
    {
        Pokemon pokemon;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public void Open()
        {
            Console.WriteLine("De Pokeball opent.");
            Console.WriteLine(pokemon.BattleCry());
        }

        public void Close()
        {
            Console.WriteLine("De Pokeball sluit.");
        }
    }
}