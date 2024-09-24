
namespace Loops_övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {





            /*For*/

            /*Skriv ut talen 1 - 10 på konsolen.
            Addera alla nummer och skriv ut dessa efter loopen.
            */

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /*Skriv kod som räknar ned från 10 till 0.*/

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            /*Be om input från användaren om hur många tal som ska skrivas ut i loopen från 1 -??.*/
            //Console.WriteLine("Hur många iterationer vill vi köra loopen?");
            //int iterationer = Convert.ToInt32( Console.ReadLine() );

            //for (int i = 1; i < iterationer; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /*Be användaren om ett ord. Skriv sedan ut ordet tio gånger med siffran framför. exp.  “1 : ordet” , “2 : ordet” ….*/

            //Console.WriteLine("Välj ett ord");
            //string ordet = Console.ReadLine();

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(ordet + " " +i);
            //}

            /*Skriv kod som skriver ut multiplikationstabellen för 5 på skärmen.
              Låt användaren välja vilken multiplikationstabell som ska skrivas ut.
            */

            //Console.WriteLine("Vilken multiplikationstabell vill du ska skrivas ut?");
            //int tabell = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + " + " + tabell + " = " + (i * tabell));
            //}

            /*Skriv ut  följande i konsolen med hjälp av din loop.
                *
                **
                ***
                ****
                *****
                ******
                *******
                */

            //for (int i = 0; i <= 7; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            /*Skriv kod som loopar mellan talen 0-100. Skriv ut “true” om numret är jämnt och “false” om det är udda.*/

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(true);
            //    }
            //    else
            //    {
            //        Console.WriteLine(false);
            //    }
            //}

            /*Skriv kod som skriver ut följande array på konsolen ett per rad. string[] fruits = { "apple", "pear", "orange", "grape" };*/
            //string[] fruits = { "apple", "pear", "orange", "grape" };

            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            /*Skriv kod som en bokstav per rad i taget skriver ut av ordet “nationalencyklopedin”.*/

            //string ordet = "nationalencyklopedin";

            //for (int i = 0; i < ordet.Length; i++)
            //{
            //    Console.WriteLine(ordet[i]);
            //}

            /*Skriv kod som ber användaren att mata in Sveriges bästa hockeylag. Om användaren matar in “fel”(inte brynäs) får den försöka igen. När rätt matas in avslutas loopen.*/

            //for (int i = 0; i < 1;)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Vilket hockeylag är bäst?");
            //    string team = Console.ReadLine().ToLower();

            //    if (team == "brynäs")
            //    {
            //        i++;
            //    }
            //}


            /*While*/

            /*Skriv ut talen 1 - 10 på konsolen. 

            Addera alla nummer och skriv ut dessa efter loopen. */
            //int index = 1;

            //while (index <= 10)
            //{
            //    Console.WriteLine(index + "b");
            //    index++;
            //}

            /*Skriv kod som räknar ned från 10 till 0. */
            //int indexb = 10;
            //while (indexb >= 0)
            //{
            //    Console.WriteLine(indexb + "c");
            //    indexb--;
            //}


            /*Be användaren att skriva in lösenord om det är rätt “loggas” användaren in. Om det är fel får denna försöka om tills det blir rätt.
              Lägg till ett max antal försök på tre stycken.
              Lägg till användarnamn som måste finnas och matcha lösenordet.
              Lägg till att användaren får försöka igen efter en minut om denna matat in fel 3 gånger i rad.
              */


            //bool RunLoop = true;
            //string correctPasswordOne = "1234";
            //string rättAnvändarNamn = "Bob";
            //int inloggningsförsök = 3;

            //while (RunLoop)
            //{
            //    Console.Clear();
            //    Console.WriteLine(inloggningsförsök + " antal försök kvar");

            //    Console.WriteLine("Skriv lösenord");
            //    string lösen = Console.ReadLine();
            //    Console.WriteLine("Skriv användarnamn");
            //    string användarNamn = Console.ReadLine();              

            //    if (inloggningsförsök < 2)
            //    {
            //        //RunLoop = false;
            //        Console.WriteLine("För många inloggningsförsök! Försök igen om tre minuter");
            //        Thread.Sleep(3000);//Sekunder istället för att det blir snabbare att testa.
            //        inloggningsförsök = 0;
            //    }
            //    if (correctPasswordOne == lösen && användarNamn == rättAnvändarNamn)
            //    {                  
            //        RunLoop = false;
            //        Console.WriteLine("Du loggas nu in");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Felaktiga uppgifter");
            //        inloggningsförsök--;                    
            //    }
            //}

            /*Skriv kod som ber användaren att mata in Sveriges bästa hockeylag. Om användaren matar in “fel”(inte brynäs) får den försöka igen. När rätt matas in avslutas loopen.*/
            //bool correctTeam = false;
            //while (correctTeam is false)
            //{
            //    Console.WriteLine("Skriv in Sveriges bästa hockeylag.");
            //    string team = Console.ReadLine().ToLower();
            //    if (team == "brynäs")
            //    {
            //        correctTeam = true;
            //    }
            //}

            /*Skriv kod som skriver ut följande array på konsolen ett per rad. string[] fruits = { "apple", "pear", "orange", "grape" };*/

            //string[] fruits = { "apple", "pear", "orange", "grape" };
            //int index = 0;
            //while (index < fruits.Length)
            //{
            //    Console.WriteLine(fruits[index]);
            //    index++;
            //}

            /*Skriv kod för ett tärningsspel. Varje runda i loopen slumpas ett tal mellan 1 och 6. 
              Ledtråd : 
              Random slump = new Random(); 
              slump.Next(1, 7);
              */

            //Random slump = new Random();

            //while (true)
            //{
            //    Console.WriteLine(slump.Next(1,7));
            //}


            /*Skriv kod för en meny med tre val.
              Meny	
              “Print”. Skriver ut ett ord sedan återgår till menyn.
              “Number”. Skriver ut ett tal sedan återgår till menyn.
              “End”. Avslutar loopen/programmet
              */
            //bool runMenu = true;
            //while (runMenu)
            //{

            //    Console.Clear();
            //    Console.WriteLine("MENY");
            //    Console.WriteLine("______________________");
            //    Console.WriteLine("1. Print");
            //    Console.WriteLine("2. Number");
            //    Console.WriteLine("3. End");
            //    Console.WriteLine("Skriv siffra och tryck på enter för att välja.");
            //    string val = Console.ReadLine();
            //    Console.Clear();
            //    switch (val)
            //    {
            //        case "1":
            //            Console.WriteLine("Print");
            //            break;
            //        case "2":
            //            Console.WriteLine("42");
            //            break;
            //        case "3":
            //            Console.WriteLine("End");
            //            runMenu = false;
            //            break;
            //        default:
            //            break;
            //    }
            //    Console.ReadKey();
            // }


            /*Skriv ut klockslag var femte sekund. Avsluta loopen efter två minuter. */

            //DateTime endTimes = DateTime.Now.AddMilliseconds(120000);
            //bool runLoop = true;
            //while (runLoop) 
            //{                
            //    DateTime now = DateTime.Now;
            //    if (now > endTimes)
            //    {
            //        runLoop = false;
            //    }
            //    Console.WriteLine(now.TimeOfDay);
            //    Thread.Sleep(5000);                
            //}


            //Do while

            /*Be användaren mata in ett ord om det inte är "exit", ber vi dem mata in igen.
             */
            //bool keepLooping = true;
            //    do
            //    {
            //        Console.WriteLine("Enter exit to .... exit");
            //        string choice = Console.ReadLine();
            //        if (choice == "exit")
            //        {
            //            keepLooping = false;
            //        }
            //    }
            //    while (keepLooping);
            /*
            Skapa ett spel där spelaren får gissa ett hemligt tal mellan 1-100. Ge ledtrådar när 
            */
            //bool incomplete = true;

            //do
            //{
            //    Console.WriteLine("Gissa ett nummer mellan 1 - 100");
            //    int guess = Convert.ToInt32(Console.ReadLine());
            //    int correctNumber = 44;
            //    if (guess < correctNumber)
            //    {
            //        Console.WriteLine("Gissa igen. Högre");
            //    }
            //    if (guess > correctNumber)
            //    {
            //        Console.WriteLine("Gissa igen. Lägre");

            //    }
            //    if (guess == correctNumber)
            //    {
            //        Console.WriteLine("Rätt");
            //        incomplete = false;
            //    }
            //}
            //while (incomplete);


            /*Skapa ett tärningsspel. Användaren får frågan om dom vill slå tärningen. Numret visas. Användaren får frågan om dom vill försöka igen eller avsluta programmet.*/

            //bool diceKeepGoing = true;
            //Random slumpTal = new Random();
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Vill du slå tärningen? ja / nej ");
            //    string val = Console.ReadLine().ToLower();

            //    if (val == "ja")
            //    {
            //        Console.WriteLine(slumpTal.Next(1,6));
            //    }
            //    if (val == "nej")
            //    {
            //        diceKeepGoing = false;
            //    }

            //    Console.WriteLine("Vill du försöka igen? ja / nej ");
            //    val = Console.ReadLine();

            //    if (val == "nej")
            //    {
            //        diceKeepGoing = false;
            //    }

            //}
            //while (diceKeepGoing);

            /*Skapa ett quiz spel med tre frågor om programmering. Om spelaren svarar rätt på alla tre visas “Grattis”. Vid första fel svar avslutas programmet.*/

            //string[] frågor = new string[3];
            //string[] svar = new string[3];

            //frågor[0] = "Vilken variabel passar för heltal";
            //svar[0] = "int";
            //frågor[1] = "Vilken variabel passar för text";
            //svar[1] = "string";
            //frågor[2] = "Vilken loop passar för att skapa samling av nummer";
            //svar[2] = "for";

            //bool incorrectAnswer = false;
            //int rättSvar = 0;
            //int index = 0;

            //do
            //{

            //    Console.WriteLine(frågor[index]);
            //    string inmatatSvar = Console.ReadLine().ToLower();
            //    if (inmatatSvar == svar[index])
            //    {
            //        Console.WriteLine("Rätt!");
            //        rättSvar++;
            //        if (rättSvar >= 3)
            //        {
            //            Console.WriteLine("Du vann spelet!");
            //            incorrectAnswer = true;
            //    }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Fel svar. Game Over!");
            //        incorrectAnswer = true;
            //    }

            //    index++;
            //}
            //while (incorrectAnswer is false);


            /*“I like Pi”. Be användaren att mata in decimalerna i pi en efter en. Om det är rätt tal skriv det ut på skärmen exp. “Bra! : 3.14”. Är det fel, avslutas programmet. Om användaren gissar 15 decimaler rätt har den vunnit.
*/
            //string piDecimals = "1415926535897931";
            //bool wrongGuess = false;
            //string gissningar = "3.";
            //int index = 0;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine(gissningar);
            //    Console.WriteLine("Skriv nästa decimal i pi: ");
            //    string nextDecimal = Console.ReadLine();
            //    if (nextDecimal[0] == piDecimals[index])
            //    {
            //        Console.WriteLine("Rätt fortsätt!");
            //        gissningar += nextDecimal;
            //        index++;
            //        if (index > piDecimals.Length - 1)
            //        {
            //            Console.WriteLine("Du vann!");
            //            Console.ReadLine();
            //            wrongGuess = true;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Game Over!");
            //        wrongGuess = true;  
            //    }              

            //}
            //while (wrongGuess is false);




            //Break

            /* Lösenordskontroll: Skapa en loop där användaren får försöka logga in med ett lösenord. Använd break för att avsluta loopen när rätt lösenord anges. Begränsa antalet försök till 5.  
         */
            //int attempts = 0;
            //bool incorrectloginattempt = true;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Total number of attempts :" + attempts);
            //    Console.WriteLine("Enter password");
            //    string password = Console.ReadLine();
            //    string correctPassword = "a2c";
            //    attempts++;
            //    if (attempts >= 5)
            //    {
            //        Console.WriteLine("Error to many tries");
            //        break;
            //    }
            //    if (password == correctPassword)
            //    {
            //        Console.WriteLine("Correct password");
            //        incorrectloginattempt = false;
            //        break;
            //    }
            //}



            /*Summa: Skriv ett program som adderar tal som användaren matar in tills summan överstiger 100. 
            * Använd break för att avsluta inmatningen när gränsen nås. */

            //int sumOfGuessedNumbers = 0;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter number");
            //    int guess = Convert.ToInt32(Console.ReadLine());

            //    sumOfGuessedNumbers += guess;
            //    if (sumOfGuessedNumbers > 100)
            //    {
            //        break;
            //    }
            //}
            //while (true);

            /*Bokstavsjakt: Be användaren mata in en mening. 
             * Använd en loop för att gå igenom varje tecken och använd break för att avsluta när den första vokalen hittas.
             * Skriv ut positionen för vokalen.*/

            //Console.WriteLine("Skriv in en mening:");
            //string mening = Console.ReadLine();

            //int position = -1;
            //for (int i = 0; i < mening.Length; i++)
            //{
            //    char tecken = char.ToLower(mening[i]);
            //    if (tecken == 'a' || tecken == 'e' || tecken == 'i' || tecken == 'o' || tecken == 'u' || tecken == 'y' || tecken == 'å' || tecken == 'ä' || tecken == 'ö')
            //    {
            //        position = i;
            //        break;
            //    }
            //}

            //if (position != -1)
            //{
            //    Console.WriteLine($"Den första vokalen hittades på position {position}");
            //}
            //else
            //{
            //    Console.WriteLine("Ingen vokal hittades i meningen.");
            //}


            /*Slumptalsgenerator: Generera slumptal mellan 1 och 10 tills talet 7 slumpas fram. 
             * Använd break för att avsluta loopen och skriv ut hur många försök som krävdes.*/

            //Random random = new Random();

            //while (true) 
            //{
            //    int tal = random.Next(1,10);
            //    Console.WriteLine(tal);
            //    if (tal == 7)
            //    {
            //        Console.WriteLine("Sjua hittad!");
            //        break;
            //    }
            //}

            /*Primtalsfinnaren: 
             * Skriv ett program som hittar det första primtalet efter ett tal som användaren matar in.
             * Använd en loop med break för att avsluta sökningen när primtalet hittas.*/

            //    Console.Write("Ange ett startnummer för att hitta nästa primtal: ");
            //    int start = int.Parse(Console.ReadLine());

            //    int primtal = 0;
            //    for (int i = start + 1; ; i++)
            //    {
            //        if (ÄrPrimtal(i))
            //        {
            //            primtal = i;
            //            break;
            //        }
            //    }

            //    Console.WriteLine($"Nästa primtal efter {start} är {primtal}.");
            //}

            //static bool ÄrPrimtal(int tal)
            //{
            //    if (tal < 2)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(tal); i++)
            //    {
            //        if (tal % i == 0)
            //            return false;
            //    }
            //    return true;


            //Continue

            /*Jämna tal: Skriv ett program som skriver ut alla jämna tal mellan 1 och 50. Använd continue för att hoppa över udda tal. */

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            /*Vokalräknare: Be användaren mata in en mening. 
             * Räkna antalet vokaler i meningen genom att använda 
             * continue för att hoppa över konsonanter och specialtecken.*/

            //Console.WriteLine("Skriv en mening");
            //string meningen = Console.ReadLine();
            //int vokaler = 0;

            //for (int i = 0; i < meningen.Length; i++)
            //{
            //    char tecken = char.ToLower(meningen[i]);


            //    if (tecken != 'a' && tecken != 'e' && tecken != 'i' && tecken != 'o' && tecken != 'u' &&
            //   tecken != 'y' && tecken != 'å' && tecken != 'ä' && tecken != 'ö')
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        vokaler++;
            //    }

            //}
            //Console.WriteLine(vokaler);



            /*Multiplar av 3 och 5: Skriv ut alla tal från 1 till 100, 
             * men använd continue för att hoppa över tal som är delbara med både 3 och 5.*/

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    if (i % 5 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            /*Namnfilter: Skapa en lista med namn. 
             * Gå igenom listan och skriv bara ut namn som börjar med en vokal. 
             * Använd continue för att hoppa över namn som börjar med en konsonant.*/

            //string[] names = { "Anka", "Betty", "Åke", "Pumba", "47" };
            //string vokaler = "aeiouyåäö";

            //for (int i = 0; i < names.Length; i++)
            //{

            //    if (!vokaler.Contains(names[i].ToLower()[0]))
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(names[i]);
            //}

            /*Sifferanalys: Be användaren mata in ett flersiffrigt tal. 
             * Gå igenom varje siffra och skriv ut den om den är större än 5. 
             * Använd continue för att hoppa över siffror som är 5 eller mindre.*/

            //Console.WriteLine("Mata in ett flersiffrigt tal");
            //string talet = Console.ReadLine();

            //for (int i = 0; i < talet.Length; i++)
            //{
            //    int tal = Convert.ToInt16(talet[i].ToString());
            //    if (tal <= 4)
            //    {
            //        continue;
            //    }
            //    if (tal > 5)
            //    {
            //        Console.WriteLine("Siffran är : " + tal);
            //    }
            //}


        }
    }

}







