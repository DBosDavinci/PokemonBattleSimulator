namespace PokemonBattleSim
{
    class Pokeball
    {
        Charmander charmander;

        public Pokeball(Charmander charmander)
        {
            this.charmander = charmander;
        }

        public void Open()
        {
            Console.WriteLine("De Pokeball opent.");
            Console.WriteLine(charmander.BattleCry());
        }

        public void Close()
        {
            Console.WriteLine("De Pokeball sluit.");
        }
    }
}