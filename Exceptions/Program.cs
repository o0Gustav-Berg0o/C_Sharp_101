try
{
    int[] numbers = new int[5];
    numbers[10] = 5;  // Detta kommer att kasta en IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Message: " + ex.Message);
    Console.WriteLine("StackTrace: " + ex.StackTrace);
    Console.WriteLine("Source: " + ex.Source);
    Console.WriteLine("HelpLink: " + ex.HelpLink);
    Console.WriteLine("HResult: " + ex.HResult);
}