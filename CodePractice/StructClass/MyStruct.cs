namespace CodePractice.StructClass;

public struct MyStruct
{
    public int StructId;

    public string StructTitle;

    public UserModel UserModel;

    public MyStruct(int structId, string structTitle, int userId, string firstName)
    {
        StructId = structId;
        StructTitle = structTitle;
        UserModel = new UserModel(userId, firstName);
    }

    public void Display(ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine($"Struct UserId: {StructId}. \t Title: {StructTitle}");
        Console.WriteLine($"User UserId: {UserModel.UserId}. FirstName: {UserModel.FirstName}");
        Console.ForegroundColor = ConsoleColor.Blue;
    }
}