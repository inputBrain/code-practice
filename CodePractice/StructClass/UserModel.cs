namespace CodePractice.StructClass;

public class UserModel
{
    public int UserId;

    public string FirstName;

    public UserModel(int userId, string firstName)
    {
        UserId = userId;
        FirstName = firstName;
    }
    
    
    public void Display(ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine($"UserId: {UserId}. \t FirstName: {FirstName}");
        Console.ForegroundColor = ConsoleColor.Blue;
    }
}