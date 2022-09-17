namespace CodePractice.Reverse;

public class ReverseText
{
    public static string ReverseWords(string? text = null)
    {
        var reversedWords = string.Empty;

        if (text != null)
        {
            var splitUserText = text.Split(' ');
            Array.Reverse(splitUserText);
            
            
            for (var i = 0; i <= splitUserText.Length - 1; i++)
            {
                reversedWords += splitUserText[i];
            }
            Console.WriteLine("Reversed Words are:");
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(reversedWords);
            return reversedWords;
        }
        
        Console.WriteLine("Enter the Text:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        var userTextInConsole = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userTextInConsole))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: text is empty or null. Please, write a text");
            return string.Empty;
        }
        
        var splitUserTextInConsole = userTextInConsole.Split(' ');
        Array.Reverse(splitUserTextInConsole);
        
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n Reversed Words are:");

        for (var i = 0; i <= splitUserTextInConsole.Length - 1; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            reversedWords += splitUserTextInConsole[i];
            Console.Write(splitUserTextInConsole[i]);
        }
        

        return reversedWords;
    }
}