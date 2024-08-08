namespace BankDemo
{
    class Program
    {

        /*  
         Fallgrop 1

         I denna demo representerar BankReserves bankens totala reserver. Det är en statisk variabel som delas av alla BankAccount-instanser.
         -Alla kontoinstanser delar och kan modifiera samma BankReserves.
         -När ett konto lägger till pengar till reserverna, påverkar det bankens totala reserver för alla konton.
         -Detta kan leda till oväntade resultat och potentiellt inkonsistent data om inte hanterat korrekt.
         
        Fallgrop 2

        PerformTransaction är en instansmetod som ändrar både instansspecifik data (Balance) och statisk data (TotalTransactions).
        Detta kan vara förvirrande eftersom metoden ser ut att vara specifik för ett konto, men den påverkar en global räknare.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Account Demo med Fallgropar:");

            BankAccount account1 = new BankAccount("Alice", 1000);
            BankAccount account2 = new BankAccount("Bob", 500);

            Console.WriteLine($"Totalt antal konton: {BankAccount.TotalAccounts}");

            // Fallgrop 1: Oavsiktlig delning av statisk data
            BankAccount.BankReserves = 10000;
            account1.AddToReserves(1000);
            Console.WriteLine($"Bank reserver efter Alice's tillägg: {BankAccount.BankReserves}");
            account2.AddToReserves(500);
            Console.WriteLine($"Bank reserver efter Bob's tillägg: {BankAccount.BankReserves}");

            // Fallgrop 2: Modifiering av statisk data från instansmetod
            account1.PerformTransaction(100);
            account2.PerformTransaction(50);
            Console.WriteLine($"Totalt antal transaktioner: {BankAccount.TotalTransactions}");

            // Visa kontosaldon
            Console.WriteLine($"Alice's saldo: {account1.Balance}");
            Console.WriteLine($"Bob's saldo: {account2.Balance}");
        }
    }

    class BankAccount
    {
        public string OwnerName { get; private set; }
        public decimal Balance { get; private set; }
        public static int TotalAccounts { get; private set; }
        public static decimal BankReserves { get; set; }
        public static int TotalTransactions { get; private set; }

        public BankAccount(string ownerName, decimal initialBalance)
        {
            OwnerName = ownerName;
            Balance = initialBalance;
            TotalAccounts++;
        }

        public void AddToReserves(decimal amount)
        {
            BankReserves += amount; // Fallgrop 1: Modifierar statisk data
        }

        public void PerformTransaction(decimal amount)
        {
            Balance += amount;
            TotalTransactions++; // Fallgrop 2: Instansmetod modifierar statisk data
        }
    }
}
