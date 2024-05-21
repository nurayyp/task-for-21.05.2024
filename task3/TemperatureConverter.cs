namespace task3
{
    internal static class TemperatureConverter
    {
        public static decimal CelsiusToFahrenheit(decimal celsius)
        {
            decimal Fahrenheit = (celsius * 9 / 5) + 32;
            return Fahrenheit;
        }
        public static decimal FahrenheitToCelsius(decimal fahranheit) 
        {
            decimal Celsius = (fahranheit - 32) * 5 / 9;
            return Celsius;
        }
    }
}
