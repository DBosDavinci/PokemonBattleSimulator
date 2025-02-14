namespace PokemonBattleSim
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name, string type, string strength, string weakness) : base(name, "Bulbasaur", strength, weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
    }
}