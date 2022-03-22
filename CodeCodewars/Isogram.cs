namespace CodeCodewars;

public class Isogram
{
    public bool IsIsogram(string str)
    {
        for (var i = 0; i < str.Length; ++i)
        {
            for (var j = i + 1; j < str.Length; ++j)
            {
                if (str.ToLower()[i] == str.ToLower()[j])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    
    public bool IsIsogram(string str, bool isBestPractices)
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }
}