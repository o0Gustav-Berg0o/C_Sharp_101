using System;

public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

    // Static egenskap
    public static decimal InterestRate { get; private set; } = 0.05m; // 5% initial ränta

    // Icke-static egenskap
    public decimal ServiceFee { get; set; } = 30.0m; // Initial serviceavgift 30 kr

    public BankAccount(string name, decimal initialBalance)
    {
        AccountHolder = name;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount - ServiceFee; // Drar av serviceavgiften vid varje insättning
    }

    public void ApplyInterest()
    {
        // Om räntesatsen är negativ kan detta vara problematiskt
        if (InterestRate < 0)
        {
            Console.WriteLine("Varning! Negativ räntesats kan inte tillämpas.");
            return;
        }
        Balance += Balance * InterestRate; // Tillämpar den statiska räntesatsen på balansen
    }

    // Static metod som kan ändra räntesatsen för alla konton
    public static void UpdateInterestRate(decimal newRate)
    {
        if (newRate < 0)
        {
            Console.WriteLine("Fel! Kan inte sätta en negativ räntesats.");
            return;
        }
        InterestRate = newRate;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("Alice", 1000);
        BankAccount acc2 = new BankAccount("Bob", 500);

        // Ändra serviceavgiften för bara en användare
        acc2.ServiceFee = 50.0m; // Bob betalar en högre serviceavgift

        // Visa initiala balanser och räntesatser
        Console.WriteLine("Initiala Balanser:");
        Console.WriteLine($"Alice: {acc1.Balance} kr, Räntesats: {BankAccount.InterestRate * 100}%, Serviceavgift: {acc1.ServiceFee} kr");
        Console.WriteLine($"Bob: {acc2.Balance} kr, Räntesats: {BankAccount.InterestRate * 100}%, Serviceavgift: {acc2.ServiceFee} kr");

        // Försök sätta en negativ räntesats
        BankAccount.UpdateInterestRate(-0.01m); // Försöker sätta räntesatsen till -1%

        // Gör insättningar
        acc1.Deposit(200); // Alice gör en insättning
        acc2.Deposit(200); // Bob gör också en insättning

        // Tillämpa ränta efter försök att ändra till en negativ räntesats
        acc1.ApplyInterest();
        acc2.ApplyInterest();

        // Visa balanser efter insättningar och räntetillämpning
        Console.WriteLine("\nBalanser efter insättningar och räntetillämpning:");
        Console.WriteLine($"Alice: {acc1.Balance} kr");
        Console.WriteLine($"Bob: {acc2.Balance} kr");
    }
}
