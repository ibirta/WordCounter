namespace WordCounter;

public class UniqueWordCounter()
{
    private static List<string> GetListOfWordsInText(string text)
    {
        return text.Split(' ').ToList();
    }
    private static HashSet<string> GetWordsInHashSet(List<string> ListOfWords)
    {
        var wordsInHashSeet = new HashSet<string>();
        foreach (var word in ListOfWords)
        {
            wordsInHashSeet.Add(word);
        }
        return wordsInHashSeet;
    }
    public int GetNumberOfUniqueWords(string text)
    {
        List<string> wordsInText = GetListOfWordsInText(text);
        var WordsInHashSet = GetWordsInHashSet(wordsInText);
        var numberOfRepeatingWords = wordsInText.Count - WordsInHashSet.Count;
        var numberOfUniqueWords = wordsInText.Count - numberOfRepeatingWords;
        return numberOfUniqueWords;
    }
}
