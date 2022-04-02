namespace CodePractice;

public class ScrambliesMain
{
    public  bool Scramble(string text, string containChar)
    {
        return text.All(c => c.StartsWith("j"));
    }
}