namespace CodePractice;

public class AlphabetPositionMain
{
    private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
    
    public string AlphabetPosition(string text)
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

        return string.Join(" ", indexCollection);
        
        // return string.Join(" ", text.ToLower().Select(letter => Alphabet.IndexOf(letter) + 1).Where(index => index > 0).ToList());
    }
}