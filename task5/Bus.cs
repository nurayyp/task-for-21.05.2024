namespace task5
{
    internal class Bus : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Bus(string brand, string model, string color)
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
            Console.WriteLine($"Bus started");
        }

        public void Stop()
        {
            Console.WriteLine($"Bus stopped");
        }
    }
}
