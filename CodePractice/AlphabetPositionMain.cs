namespace CodePractice;

public class AlphabetPositionMain
{
    private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
    
    public string TextToAlphabetPositions(string text)
    {
        var indexCollection = new List<int>();

        foreach (var letter in text.ToLower())
        {
            var index = Alphabet.IndexOf(letter) +1;
            if (index > 0)
            {
                indexCollection.Add(index);
            }
        }

        Console.WriteLine(string.Join(" ", indexCollection));
        return string.Join(" ", indexCollection);
        
        // return string.Join(" ", text.ToLower().Select(letter => Alphabet.IndexOf(letter) + 1).Where(index => index > 0).ToList());
    }

    public string AlphabetPositionsToText(List<int> alphabetPositions)
    {
        var preparedString = string.Empty;

        foreach (var position in alphabetPositions)
        {
            foreach (var alp in Alphabet)
            {
                var index = Alphabet.IndexOf(alp) + 1;
                if (position == index)
                {
                    preparedString += alp;
                }
            }
        }

        Console.WriteLine(string.Join(" ", preparedString));
        return string.Join(" ", preparedString);
    }
}