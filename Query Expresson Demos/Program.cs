namespace Query_Expresson_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          // DemoOne();
          // DemoTwo();
          // DemoThree();
            DemoFour();
            Console.ReadLine();
        }

        static void DemoOne()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = 
                              from number in numbers
                                            // Titta på alla nummer i arrayen "numbers"
                              where number % 2 == 0
                                            // Behåll endast nummer som är jämna
                              orderby number descending
                                            // Sortera i fallande ordning
                              select number;
                                            // Spara hela objektet.


            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            // Output: 10, 8, 6, 4, 2
        }
        static void DemoTwo()
        {
            List<Person> people = new List<Person>
        {
            new Person { FirstName = "Alice", LastName = "Johnson", Age = 30 },
            new Person { FirstName = "Bob", LastName = "Smith", Age = 25 },
            new Person { FirstName = "Charlie", LastName = "Brown", Age = 35 },
            new Person { FirstName = "David", LastName = "Lee", Age = 28 }
        };

            var firstNames = 
                             from person in people
                             //Titta på alla personer i arrayen "people"

                             orderby person.Age
                             //Sortera listan efter ålder

                             select person.FirstName;
                             //Spara endast förnamnen i listan "firstName"

            Console.WriteLine("First names, sorted by age:");
            foreach (var name in firstNames)
            {
                Console.WriteLine(name);
            }
        }
        static void DemoThree()
        {
            List<Pokemon> pokemons = new List<Pokemon>
        {
            new Pokemon { Name = "Pikachu", Type = "Electric", Level = 15 },
            new Pokemon { Name = "Charizard", Type = "Fire", Level = 36 },
            new Pokemon { Name = "Squirtle", Type = "Water", Level = 8 },
            new Pokemon { Name = "Bulbasaur", Type = "Grass", Level = 12 },
            new Pokemon { Name = "Gyarados", Type = "Water", Level = 30 },
            new Pokemon { Name = "Gengar", Type = "Ghost", Level = 25 },
            new Pokemon { Name = "Jolteon", Type = "Electric", Level = 20 }
        };

            var groupedPokemons = from pokemon in pokemons
                                  //Titta på varje pokemon i listan pokemons
                                  group pokemon by pokemon.Type into typeGroup
                                  //Gruppera samtliga efter kategorin "Type"
                                  orderby typeGroup.Key
                                  //Sortera grupp namnet i detta fall hamnar alla Electric i en grupp med namnet "Electric"
                                  select new
                                  {
                                      //Spara som nytt objekt

                                      //Type = gruppnamnet
                                      Type = typeGroup.Key,

                                      //Antal pokemons i gruppen

                                      Count = typeGroup.Count(),

                                      //Snittnivå för pokemons i gruppen
                                      AverageLevel = typeGroup.Average(p => p.Level),

                                      //Lista med pokemonobjekt i denna grupp
                                      Pokemons = typeGroup.OrderBy(p => p.Name)

                                  };
                                  

            // Titta i groupedPokemonms -> resultView

            foreach (var group in groupedPokemons)
            {
                Console.WriteLine($"Type: {group.Type}");
                Console.WriteLine($"Count: {group.Count}");
                Console.WriteLine($"Average Level: {group.AverageLevel:F1}");
                Console.WriteLine("Pokemons:");
                foreach (var pokemon in group.Pokemons)
                {
                    Console.WriteLine($"  - {pokemon.Name} (Level {pokemon.Level})");
                }
                Console.WriteLine();
            }
        }
        static void DemoFour() //Join
        {

            List<Person> people = new List<Person>
        {
            new Person { Id = 1, FirstName = "Alice" },
            new Person { Id = 2, FirstName = "Bob" },
            new Person { Id = 3, FirstName = "Charlie" },
            new Person { Id = 4, FirstName = "David" }
        };

            List<Address> addresses = new List<Address>
        {
            new Address { PersonId = 1, Street = "123 Main St", City = "New York" },
            new Address { PersonId = 2, Street = "456 Elm St", City = "Los Angeles" },
            new Address { PersonId = 3, Street = "789 Oak St", City = "Chicago" },
            new Address { PersonId = 5, Street = "101 Pine St", City = "San Francisco" }
        };

            //Inner join - Tar bara med objekt om matching finns
            var peopleWithAddresses = from person in people
                                      //Kolla på alla personer i listan people
                                      join address in addresses
                                      //Sätt samman med listan addresses 
                                      on person.Id equals address.PersonId
                                      //Om det finns matchande Id i people(ID) och addresses(PersonId)
                                      select new
                                      {
                                          //Skapa nytt objekt om matchning fanns
                                          PersonName = person.FirstName,
                                          //PersonName fylls i med FirstName från listan people
                                          Address = $"{address.Street}, {address.City}"
                                          //Address fylls i med gatuaddress och stad från listan address
                                      };

            Console.WriteLine("People with their addresses:");
            foreach (var item in peopleWithAddresses)
            {
                Console.WriteLine($"{item.PersonName}: {item.Address}");
            }

            // Exempel på en left outer join - Tar med alla personer från listan people och alla addresser med matchning från listan addresses 
            var allPeopleWithAddresses = from person in people

                                         //Kolla på alla personer i listan people
                                         join address in addresses

                                         //Sätt samman med listan addresses 
                                         on person.Id equals address.PersonId into addressGroup

                                         // Matchningen görs baserat på person.Id och address.PersonId
                                         // Resultatet av matchningen sparas i en grupp kallad 'addressGroup'
                                         // 'into' skapar en tillfällig variabel (addressGroup) som innehåller alla matchande adresser för varje person
                                        
                                         from address in addressGroup.DefaultIfEmpty()
                                             // Denna rad hanterar fall där en person inte har någon matchande adress
                                             // Om det inte finns någon matchning, kommer 'address' att vara null
                                          
                                         // DefaultIfEmpty() säkerställer att vi får ett resultat för varje person, även om de inte har en adress
                                         select new
                                         {
                                             //PersonName fylls i med FirstName från listan people
                                             PersonName = person.FirstName,

                                             // Om address är null (ingen matchning hittades), sätter vi "No address"
                                             // Annars kombinerar vi gatuadress och stad till en sträng
                                             Address = address == null ? "No address" : $"{address.Street}, {address.City}"
                                         };

            Console.WriteLine("\nAll people with addresses (including those without):");
            foreach (var item in allPeopleWithAddresses)
            {
                Console.WriteLine($"{item.PersonName}: {item.Address}");
            }
        }
    }
    
}
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public class Pokemon
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
}

public class Address
{
    public int PersonId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
}

