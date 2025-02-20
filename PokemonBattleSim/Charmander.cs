namespace PokemonBattleSim
{
    class Charmander : Pokemon
    {

        public Charmander() : base("Charmander", PokemonType.Fire, PokemonType.Water) {}

        override public string BattleCry()
        {
            return name + " schreeuwt 'Charmander!'";
        }
    }
}