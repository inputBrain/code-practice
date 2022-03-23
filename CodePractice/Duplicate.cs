namespace CodePractice;

public class Duplicate
{
    public int DuplicateCount(string str)
    {
        var preparedChars = new List<string>();
        
        for (var i = 0; i < str.Length; i++)
        {
            for (var j = i; j < str.Length; j++)
            {
                if (str.ToLower()[i] == str.ToLower()[j])
                {
                    preparedChars.Add(str);
                }
            }
        }

        return preparedChars.Count;
    }
}