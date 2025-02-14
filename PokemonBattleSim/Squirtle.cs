namespace PokemonBattleSim
{
    class Squirtle : Pokemon
    {

        public Squirtle(string name, string type, string strength, string weakness) : base(name, "Squirtle", strength, weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
    }
}