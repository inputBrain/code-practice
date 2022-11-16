namespace CodePractice.Alphabet;

public class AlphabetManipulation
{
    private const string EnglishAlphabet = "abcdefghijklmnopqrstuvwxyz";
    
    public static string TextToAlphabetPositions(string text)
    {
        var indexCollection = new List<int>();

        foreach (var letter in text.ToLower())
        {
            var index = EnglishAlphabet.IndexOf(letter) +1;
            if (index > 0)
            {
                indexCollection.Add(index);
            }
        }

        return string.Join(" ", indexCollection);
        
        // return string.Join(" ", text.ToLower().Select(letter => Alphabet.IndexOf(letter) + 1).Where(index => index > 0).ToList());
    }

    public static string AlphabetPositionsToText(List<int> alphabetPositions)
    {
        var preparedString = string.Empty;

        foreach (var position in alphabetPositions.Where(x => x <= 26))
        {
            foreach (var alp in EnglishAlphabet)
            {
                var index = EnglishAlphabet.IndexOf(alp) + 1;
                if (position == index)
                {
                    preparedString += alp;
                }
            }
        }

        return string.Join(" ", preparedString);
        
        // var preparedString = (from position in alphabetPositions.Where(x => x <= 26)
        // from alp in EnglishAlphabet let index = EnglishAlphabet.IndexOf(alp) + 1
        // where position == index select alp).Aggregate(string.Empty, (current, alp) => current + alp);
    }
}