using task4;

public static class Program
{
    public static void Main()
    {
        DateTime newDate = new DateTime(2006, 5, 23);
        Console.WriteLine(DateTimeExtension.CalculateAge(newDate));
    }
}