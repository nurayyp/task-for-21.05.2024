namespace task6
{
    internal static class StringExtension
    {
        public static bool IsPolindrom(string word)
        {
            int middle = word.Length ;
            int a = 0;
            int b = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[word.Length-1-i])
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            if (a == middle)
            { return true; }
            return false;
        }
    }
}
