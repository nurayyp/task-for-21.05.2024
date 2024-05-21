namespace task9._1;
internal static class ReverseExtension
{
    public static string ReverseWord(string word)
    {
        char[] array = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            array[i] = word[word.Length - 1 - i];
        }
        string newWord = new string(array);
        return newWord;
    }
}
