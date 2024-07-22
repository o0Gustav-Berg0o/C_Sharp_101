using System;
using System.IO;

class ExceptionDemo
{
    static void Main()
    {
        Console.WriteLine("Exception Demonstration\n");




        try
        {
            // Demonstrera olika typer av exceptions
            DemonstrateExceptions();
        }
        catch (Exception ex)
        {
            // Denna catch-block fångar alla typer av exceptions
            Console.WriteLine("Ett oväntat fel inträffade:");
            Console.WriteLine($"Typ: {ex.GetType().Name}");
            Console.WriteLine($"Meddelande: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }

        Console.WriteLine("\nTryck på en tangent för att avsluta.");
        Console.ReadKey();
    }

    static void DemonstrateExceptions()
    {
        try
        {
            Console.WriteLine("1. ArgumentException");
            ThrowArgumentException();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Fångad: {ex.GetType().Name}");
            Console.WriteLine($"Meddelande: {ex.Message}\n");
        }

        try
        {
            Console.WriteLine("2. IndexOutOfRangeException");
            ThrowIndexOutOfRangeException();
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Fångad: {ex.GetType().Name}");
            Console.WriteLine($"Meddelande: {ex.Message}\n");
        }

        try
        {
            Console.WriteLine("3. FileNotFoundException");
            ThrowFileNotFoundException();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Fångad: {ex.GetType().Name}");
            Console.WriteLine($"Meddelande: {ex.Message}");
            Console.WriteLine($"Filnamn: {ex.FileName}\n");
        }

        try
        {
            Console.WriteLine("4. Custom Exception med Inner Exception");
            ThrowCustomExceptionWithInner();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Fångad: {ex.GetType().Name}");
            Console.WriteLine($"Meddelande: {ex.Message}");
            Console.WriteLine($"Custom Data: {ex.CustomData}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
            }
        }
    }

    static void ThrowArgumentException()
    {
        throw new ArgumentException("Ogiltigt argument");
    }

    static void ThrowIndexOutOfRangeException()
    {
        int[] arr = new int[5];
        int value = arr[10]; // Detta kommer att kasta IndexOutOfRangeException
    }

    static void ThrowFileNotFoundException()
    {
        throw new FileNotFoundException("Filen kunde inte hittas", "icke_existerande_fil.txt");
    }

    static void ThrowCustomExceptionWithInner()
    {
        try
        {
            throw new DivideByZeroException("Försökte dela med noll");
        }
        catch (DivideByZeroException ex)
        {
            throw new CustomException("Ett anpassat fel uppstod", "Extra information", ex);
        }
    }
}

class CustomException : Exception
{
    public string CustomData { get; private set; }

    public CustomException(string message, string customData, Exception inner)
        : base(message, inner)
    {
        CustomData = customData;
    }
}