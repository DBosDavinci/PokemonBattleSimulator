namespace PokemonBattleSim
{
    class Bulbasaur : Pokemon
    {

        public Bulbasaur() : base("Bulbasaur", PokemonType.Grass, PokemonType.Fire) {}

        override public string BattleCry()
        {
            return name + " schreeuwt 'Bulbasaur!'";
        }
    }
}