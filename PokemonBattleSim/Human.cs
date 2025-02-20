namespace PokemonBattleSim
{
    abstract class Human
    {
        public string name;

        public Human(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}