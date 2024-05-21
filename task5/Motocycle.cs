
namespace task5
{
    internal class Motocycle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Motocycle(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Brand} {Model} {Color}");
        }
        public void Start()
        {
            Console.WriteLine($"Motocycle started");
        }

        public void Stop()
        {
            Console.WriteLine($"Motocycle stopped");
        }
    }
}
