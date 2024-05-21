namespace task7
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        public User(string name, string surname, string pin, RegistrationMonth registrationMonth)
        {
            Name = name;
            Surname = surname;
            PIN = pin;
            RegistrationMonth = registrationMonth;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Surname} {PIN} {RegistrationMonth}");
        }
        public string PinExtension()
        {
            if ()
            {
                
            }
            else
            {
                Console.WriteLine("Sifre 7 simvoldan ibaret olmalidir, boyuk herf ve reqem");
            }
        }
    }
    public enum RegistrationMonth : int
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
