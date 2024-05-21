using task7;

public static class Program
{
    public static void Main()
    {
        User user1 = new User("Nuray", "Pashayeva", "NUR2006", RegistrationMonth.March);
        user1.GetDetails();
        User user2 = new User("Gunel", "Eliyeva", "_enar234", RegistrationMonth.December);
        user2.GetDetails();
        User user3 = new User("Sona", "Abbasova", "kds2Ad1", RegistrationMonth.August);
        user3.GetDetails();
        User user4 = new User("Ilkin", "Ismayilov", "756THJK", RegistrationMonth.July);
        user4.GetDetails();
        User user5 = new User("Nihad", "Qasimov", "fhGAt23", RegistrationMonth.May);
        user5.GetDetails();
    }
}