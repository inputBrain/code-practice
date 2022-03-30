using Microsoft.VisualBasic.CompilerServices;

namespace CodePractice;

public class AlphabetPositionMain
{
    private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
    
    public string AlphabetPosition(string text)
    {
        var positionCollection = new List<int>();

        foreach (var letter in text.ToLower())
        {
            positionCollection.Add(Alphabet.IndexOf(letter));
        }

        return string.Join(" ", positionCollection);
    }
}