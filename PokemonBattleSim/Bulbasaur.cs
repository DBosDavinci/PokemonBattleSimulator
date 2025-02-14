namespace PokemonBattleSim
{
    class Bulbasaur : Pokemon
    {

        public Bulbasaur(string name, string strength, string weakness) : base(name, strength, weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }

        override public string BattleCry()
        {
            return name + " schreeuwt 'Bulbasaur!'";
        }
    }
}