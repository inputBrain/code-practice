namespace CodePractice.StructClass;

public static class MainStructClass
{
    public static async Task Main()
    {
        await Task.Run(
            () =>
            {
                var myStruct = new MyStruct(1, "Original User Struct", 10, "Oleg");
                
                var copyMyStruct = myStruct;
                copyMyStruct.StructId = 2;
                copyMyStruct.StructTitle = "Copied struct title was changed";
                copyMyStruct.UserModel.UserId = 500;
                copyMyStruct.UserModel.FirstName = "Copied user first name was changed";

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\t\t ------ Original struct ------ ");
                myStruct.Display(consoleColor: ConsoleColor.Cyan);

                Console.WriteLine("\n\t\t\t ------ Copied struct ------ ");
                copyMyStruct.Display(consoleColor: ConsoleColor.Yellow);

                Console.WriteLine("\n\t\t\t ------ User Model Manipulation ------");

                var userModel = new UserModel(1, "Alex");

                var copyUserModel = userModel;
                copyUserModel.UserId = 2;
                copyUserModel.FirstName = "Bob";


                userModel.Display(consoleColor: ConsoleColor.Cyan);
                copyUserModel.Display(consoleColor: ConsoleColor.Yellow);
            });
    }
}