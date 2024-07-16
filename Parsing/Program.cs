namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            #region Parse From String

            string age = "23";
            Console.WriteLine($"{age}. Is of type: {age.GetType().Name}\n");

            int ageAsNumber = int.Parse(age);
            Console.WriteLine($"{ageAsNumber}. Is of type: {ageAsNumber.GetType().Name}\n");

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

            #region Parse From Integer
            int weight = 1000;
            Console.WriteLine($"{weight}. Is of type: {weight.GetType().Name}\n");

            decimal decimalFromInt = (decimal)weight;
            Console.WriteLine($"{decimalFromInt}. Is of type: {decimalFromInt.GetType().Name}\n");

            short shortAsString = (short)weight;
            Console.WriteLine($"{shortAsString}. Is of type: {shortAsString.GetType().Name}\n");

            uint uintAsString = (uint)weight;
            Console.WriteLine($"{uintAsString}. Is of type: {uintAsString.GetType().Name}\n");

            #endregion

            #region Parse Fail and data loss
            Console.WriteLine("ERRORS");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.ReadLine();

            //Int 32 to int 16
            //int -31 to uint
            //decimal 3.123 to int

            int bigNum = 123315468;

            short ageAsNumberError = (short)bigNum; //casting
            Console.WriteLine(ageAsNumberError);
           
            #endregion

        }
    }
}
