namespace PokemonBattleSim
{
    class Charmander : Pokemon
    {

        public Charmander(string name, string strength, string weakness) : base(name, "Charmander", strength, weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
    }
}