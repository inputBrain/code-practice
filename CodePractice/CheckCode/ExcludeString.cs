namespace CodePractice.CheckCode;

public class ExcludeString
{
    public static void ProcessIncludeAndExclude(IEnumerable<string> includeWords, IEnumerable<string> excludeWords)
    {
        var preparedCollection = includeWords.Except(excludeWords);
        foreach (var excludeWord in preparedCollection)
        {
            Console.WriteLine(excludeWord);
        }

    }
}