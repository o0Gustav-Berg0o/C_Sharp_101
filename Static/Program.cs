using System;
using System.Collections.Generic;

namespace PokemonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skapar Pokemons och demonstrerar fallgropar:");

            Pokemon pika1 = new Pokemon("Pikachu", 10);
            Pokemon pika2 = new Pokemon("Pikachu", 15);
            Pokemon charm = new Pokemon("Charmander", 12);

            Console.WriteLine($"Totalt antal Pokemon: {Pokemon.NumberOfPokemon}");
            Console.WriteLine($"Pika1 level: {pika1.Level}, Pika2 level: {pika2.Level}");

            // Fallgrop 1: Oavsiktlig delning av statisk data
            Pokemon.SharedBattlePoints = 100;
            pika1.AddBattlePoints(50);
            Console.WriteLine($"Pika1 battle points: {Pokemon.SharedBattlePoints}");
            Console.WriteLine($"Pika2 battle points: {Pokemon.SharedBattlePoints}");

            // Fallgrop 2: Modifiering av statisk data från instansmetod
            pika1.IncrementSharedCounter();
            pika2.IncrementSharedCounter();
            Console.WriteLine($"Shared counter: {Pokemon.SharedCounter}");

            Console.ReadKey();
        }
    }

    class Pokemon
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public static int NumberOfPokemon { get; private set; }
        public static int SharedBattlePoints { get; set; }
        public static int SharedCounter { get; private set; }
        public static List<Pokemon> SharedPokemonList { get; } = new List<Pokemon>();

        public Pokemon(string name, int level)
        {
            Name = name;
            Level = level;
            NumberOfPokemon++;
        }

        public void AddBattlePoints(int points)
        {
            SharedBattlePoints += points; // Fallgrop 1: Modifierar statisk data
        }

        public void IncrementSharedCounter()
        {
            SharedCounter++; // Fallgrop 2: Instansmetod modifierar statisk data
        }

        public static void StaticLevelUp(Pokemon pokemon)
        {
            pokemon.Level++; // Fallgrop 3: Statisk metod modifierar instansdata
        }

        public static void AddToSharedList(Pokemon pokemon)
        {
            SharedPokemonList.Add(pokemon); // Fallgrop 4: Delar en statisk lista mellan alla instanser
        }
    }
}
