namespace CodePractice.InterestingCode;

public class DrawStars
{
    public static void DrawStarsMain(int totalStars)
    {
        if (totalStars <= 0)
        {
            Console.WriteLine("Dude, it's over our logic! :D");
        }

        var maxStarsInOneLine = totalStars / 2;
        var starCollection = new List<string>();

        for (var i = 0; i < maxStarsInOneLine; i++)
        {
            for (var j = 0; j < i; j++)
            {
                var result = string.Concat(Enumerable.Repeat("*", j));
                starCollection.Add(result);
            }
        }
    }
}