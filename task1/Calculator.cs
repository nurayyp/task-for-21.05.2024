namespace task1
{
    internal class Calculator : ICalculator
    {
        public int Add (int number1, int number2)
        {
            return number1 + number2;
        }
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiply(int number1, int number2)
        { 
            return number1 * number2; 
        }
        public int Divide(int number1, int number2)
        { 
            return number1 / number2; 
        }
    }
}
