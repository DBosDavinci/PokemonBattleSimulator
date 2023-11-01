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

        public void ThrowPokeball(int number)
        {
            Console.WriteLine(name + " heeft een Pokeball gegooid");
            belt[number].Open();
        }

        public void ReturnPokemon(int number)
        {
            Console.WriteLine(name + " heeft een Pokemon teruggehaald");
            belt[number].Close();
        }
    }
}