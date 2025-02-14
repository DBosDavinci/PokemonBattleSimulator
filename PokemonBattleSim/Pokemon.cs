namespace PokemonBattleSim
{
    class Pokemon
    {
        public string name;
        public string type;
        public string strength;
        public string weakness;

        public Pokemon(string name, string type, string strength, string weakness)
        {
            this.name = name;
            this.type = type;
            this.strength = strength;
            this.weakness = weakness;
        }

        public string BattleCry()
        {
            return name + $" schreeuwt '{type}!'";
        }
    }
}