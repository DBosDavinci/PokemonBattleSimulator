namespace PokemonBattleSim
{
    class Squirtle : Pokemon
    {

        public Squirtle() : base("Squirtle", PokemonType.Water, PokemonType.Grass) {}

        override public string BattleCry()
        {
            return name + " schreeuwt 'Squirtle!'";
        }
    }
}