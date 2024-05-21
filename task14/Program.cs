using task14;

public static class Program
{
    public static void Main()
    {
        TrafficLight trafficLight = new TrafficLight(TrafficLight.Color.Green);
        Console.WriteLine(trafficLight.GetColor());
        trafficLight.ChangeColor();
        Console.WriteLine(trafficLight.GetColor());
        trafficLight.ChangeColor();
        Console.WriteLine(trafficLight.GetColor());
        trafficLight.ChangeColor();
        Console.WriteLine(trafficLight.GetColor());
    }
}