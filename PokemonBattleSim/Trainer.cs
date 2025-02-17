namespace PokemonBattleSim
{
    class Trainer
    {
        string name;
        List<Pokeball> belt;

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
        }

        public List<Pokeball> GetBelt()
        {
            return belt;
        }

        public void SetBelt(List<Pokeball> belt)
        {
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