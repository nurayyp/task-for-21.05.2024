namespace task4
{
    internal static class DateTimeExtension
    {
        public static int CalculateAge(this DateTime birthDate)
        {
            DateTime todaysDate = DateTime.Now;
            if (birthDate.Month - todaysDate.Month < 0 || (birthDate.Month == todaysDate.Month && birthDate.Day - todaysDate.Day < 0))
            {
                return todaysDate.Year - birthDate.Year;
            }
            else
                return todaysDate.Year - birthDate.Year - 1;
        }
    }
}
