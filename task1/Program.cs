using task1;

public static class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(32, 41));
        Console.WriteLine(calculator.Subtract(34,13));
        Console.WriteLine(calculator.Multiply(3,6));
        Console.WriteLine(calculator.Divide(56,7));
    }
}