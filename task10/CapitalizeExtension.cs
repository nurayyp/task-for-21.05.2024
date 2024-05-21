namespace task10._1
{
    internal static class CapitalizeExtension
    {
        public static string Capitalize(this string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
