string bob = "bob";
String bob2 = "bob";
Int128 alice = 11;


string elite = "1337";
string choice = "false";
string value = "3.14";

int eliteConverted = int.Parse(elite);

short s = 100;
Console.WriteLine(s);
int i = s; // Implicit konvertering från short till int
Console.WriteLine(i);



decimal temperature = 21.4m;

int temperatureConvertedFromDecimal = (int)temperature;
Console.WriteLine(temperatureConvertedFromDecimal);
Console.ReadLine();

// Explicit konvertering från double till int
double decimalTal = 3.14;
int heltal = (int)decimalTal;
Console.WriteLine($"Double {decimalTal} konverterad till int: {heltal}");

// Explicit konvertering från long till int
long storTal = 2147483648; // Detta tal är större än int.MaxValue
int mindreHeltal = (int)storTal;
Console.WriteLine($"Long {storTal} konverterad till int: {mindreHeltal}");
//Här skapar vi en long-variabel med värdet 2147483648. Det är viktigt att notera att detta tal är precis ett steg över int.MaxValue, som är 2147483647.
//Det intressanta här är att resultatet blir -2147483648, vilket är int.MinValue. Detta fenomen kallas "integer overflow"
//När vi försöker konvertera 2147483648 (som är 2^31) till en int, "rullar" värdet över till det lägsta möjliga negativa talet, vilket är -2^31 (-2147483648).

// Explicit konvertering från string till int
string talSomText = "123";
int talFranText = Convert.ToInt32(talSomText);
Console.WriteLine($"String \"{talSomText}\" konverterad till int: {talFranText}");


string beloppSträng = "123.45";

var beloppSträng2 = Convert.ToDecimal(beloppSträng);

Console.WriteLine(beloppSträng2);