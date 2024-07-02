namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parse From String

            string age = "23";
            Console.WriteLine($"{age}. Is of type: {age.GetType().Name}\n");

            int ageAsNumber = int.Parse(age);
            Console.WriteLine($"{ageAsNumber}. Is of type: {ageAsNumber.GetType().Name}\n");

            string ageError = "23a";
            //int ageAsNumberError = int.Parse(ageError);
            //Console.WriteLine(ageAsNumberError);

            decimal ageAsDecimal = decimal.Parse(age);
            Console.WriteLine($"{ageAsDecimal}. Is of type: {ageAsDecimal.GetType().Name}\n");

            string singleLetter = "A";
            Console.WriteLine($"{singleLetter}. Is of type: {singleLetter.GetType().Name}\n");

            char letter = char.Parse(singleLetter);
            Console.WriteLine($"{letter}. Is of type: {letter.GetType().Name}\n");

            string guidAsString = "67ad96d0-f367-4cc2-a8c8-c37533317cde";
            Guid guid = Guid.Parse(guidAsString);
            Console.WriteLine($"{guid}. Is of type: {guid.GetType().Name}\n");


            string boolAsString = "true";
            bool boolFromString = bool.Parse(boolAsString);
            Console.WriteLine($"{boolFromString}. Is of type: {boolFromString.GetType().Name}\n");

            string decimalAsString = "1,2";
            decimal decimalFromString = decimal.Parse(decimalAsString);
            Console.WriteLine($"{decimalFromString}. Is of type: {decimalFromString.GetType().Name}\n");

            #endregion





        }
    }
}
