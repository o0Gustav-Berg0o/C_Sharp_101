string? name = null;

// 1. Standardkontroll med ==
if (name == null) // == kan bli överskriden för referenstyper, men är säker för string
{
    Console.WriteLine("Name is null (==)");
}

// 2. Kontroll med !=
if (name != null) // != kan också bli överskriden
{
    Console.WriteLine("Name is not null (!=)");
}

// 3. Använd ReferenceEquals för exakt referenskontroll
if (ReferenceEquals(name, null)) // Kollar om instanserna pekar på samma minnesplats
{
    Console.WriteLine("Name and null point to the same memory location");
}

// 4. Mönstermatchning med 'is null'
if (name is null) // Garanterar att en ej överskridbar == används
{
    Console.WriteLine("Name is null (is null)");
}

// 5. Mönstermatchning med 'is not null'
if (name is not null)
{
    Console.WriteLine($"Name is not null: {name}");
}
else
{
    Console.WriteLine("Name is null (is not null else)");
}

// 6. Null-coalescing operator ??
string displayName = name ?? "Inget namn angivet";
Console.WriteLine($"Displayname: {displayName}");

// 7. Null-conditional operator ?.
int? length = name?.Length;
Console.WriteLine($"Name length: {length ?? 0}");

// 8. Använd string.IsNullOrEmpty för att kontrollera null eller tom sträng
if (string.IsNullOrEmpty(name))
{
    Console.WriteLine("Name is null or empty");
}

// 9. Använd string.IsNullOrWhiteSpace för att kontrollera null, tom sträng eller endast whitespace
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Name is null, empty, or whitespace");
}

// 10. Använda null-forgiving operator ! (använd med försiktighet)
#nullable enable
string notNullName = name!;
Console.WriteLine($"Not null name length: {notNullName.Length}");
#nullable restore