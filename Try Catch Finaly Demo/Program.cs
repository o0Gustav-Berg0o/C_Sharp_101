using System.Net;
using System.Runtime.InteropServices;

bool success = false;

try
{
    throw new HttpRequestException();   
}
catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine("Resursen hittades inte.");
}
catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.InternalServerError)
{
    Console.WriteLine("Servern rapporterade ett internt fel.");
}
catch (HttpRequestException ex)
{
    Console.WriteLine("Ett HTTP-fel inträffade: " + ex.Message);
}

while (!success)
{
    try
    {
        // Ta emot användarinput och försök konvertera till ett heltal
        Console.WriteLine("Skriv din ålder:");
        int ålder = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Din ålder är: " + ålder);
        success = true; // Konvertering lyckades
    }
    catch (FormatException felmeddelande)
    {
        // Värdet kunde inte konverteras. Ge felmeddelande till användaren
        Console.WriteLine("Felaktigt värde. Endast heltal är tillåtna.");
        Console.WriteLine(felmeddelande.Message);
    }
    finally
    {
        // Detta block körs alltid
        Console.WriteLine("Försök igen.");
    }
}