namespace CodePractice.Algorithm;

public class Duplicate
{
    public static int CountDuplicateLettersInText(string text)
    {
        var duplicateCollection = new List<string>();
        
        for (var i = 0; i < text.Length; i++)
        {
            for (var j = i; j < text.Length; j++)
            {
                if (text.ToLower()[i] == text.ToLower()[j])
                {
                    duplicateCollection.Add(text);
                }
            }
        }

        return duplicateCollection.Count;
    }
}