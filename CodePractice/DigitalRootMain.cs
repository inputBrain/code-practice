// 16  -->  1 + 6 = 7
// 942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
// 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
// 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
public class DigitalRootMain
{
    public int DigitalRoot(long n)
    {
        var cutNumberByChars = n.ToString().ToCharArray();

        var result = cutNumberByChars.Sum(c => long.Parse(c.ToString()));

        if (result < 10)
        {
            return int.Parse(result.ToString());
        }
    
        return DigitalRoot(result);
    }
    

    public int BestPractices(long n)
    {
        return (int)(1 + (n - 1) % 9);
    }
}