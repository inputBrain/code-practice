namespace CodePractice.Algorithm;

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


    public bool BestPractices(string str)
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }
}