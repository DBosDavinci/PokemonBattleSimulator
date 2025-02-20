namespace PokemonBattleSim
{
    abstract class Pokemon
    {
        readonly public string name;
        readonly public PokemonType strength;
        readonly public PokemonType weakness;

        public Pokemon(string name, PokemonType strength, PokemonType weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }

        public abstract string BattleCry();
    }
}