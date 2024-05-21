using task5;

public static class Program
{
    public static void Main()
    {
        Bus bus = new Bus("bakubus","11","red");
        Car car = new Car("BMW","M4","Black");
        Motocycle motocycle = new Motocycle("Kawasaki", "Ninja h2r", "Green");
        bus.Start();
        bus.Stop();
        bus.GetDetails();
        car.Start();
        car.Stop();
        car.GetDetails();
        motocycle.Start();
        motocycle.Stop();
        motocycle.GetDetails();
    }
}