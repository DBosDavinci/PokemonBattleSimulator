namespace PokemonBattleSim
{
    abstract class Pokemon
    {
        public string name;
        public string strength;
        public string weakness;

        public Pokemon(string name, string strength, string weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }

        public abstract string BattleCry();
    }
}