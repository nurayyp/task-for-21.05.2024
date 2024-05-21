namespace task8._1
{
    internal static class ArrayExtension
    {
        public static decimal GetAverage(int[] array)
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}
