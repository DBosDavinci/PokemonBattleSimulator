class PokemonBattleSim
{
    public static void Main(string[] args)
    {
        Pokemon Charmander = new Pokemon("Charmander", "fire", "water");

        while (true)
        {
            Console.WriteLine("Enter Pokemon name:");
            string? name = Console.ReadLine();
            Charmander.SetName(name);

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(Charmander.BattleCry() + "!!!!");
            }
        }
    }

    class Pokemon
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

        public String BattleCry()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
    }
}