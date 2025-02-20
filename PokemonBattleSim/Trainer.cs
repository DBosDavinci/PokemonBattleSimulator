namespace PokemonBattleSim
{
    class Trainer
    {
        string name;
        List<Pokeball> belt;
        int maxBeltSize = 6;

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;

            if (belt.Count > maxBeltSize)
                throw new ArgumentOutOfRangeException("Too many pokemon on the belt");
        }

        public List<Pokeball> GetBelt()
        {
            return belt;
        }

        public void SetBelt(List<Pokeball> belt)
        {
            if (belt.Count > maxBeltSize)
                throw new ArgumentOutOfRangeException("Too many pokemon on the belt");

            this.belt = belt;
        }

        public string GetName()
        {
            return name;
        }

        public Pokemon ThrowPokeball(int number)
        {
            Console.WriteLine(name + " heeft een Pokeball gegooid");
            return belt[number].Open();
        }

        public void ReturnPokemon(int number)
        {
            Console.WriteLine(name + " heeft een Pokemon teruggehaald");
            belt[number].Close();
        }
    }
}