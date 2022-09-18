namespace CodePractice.Reverse;

public class ReverseText
{
    public static string? ReverseWords(string? text = null)
    {
        var reversedWords = string.Empty;

        if (text != null)
        {
            var reversedUserText = text.Split(' ');
            Array.Reverse(reversedUserText);
            
            
            for (var i = 0; i <= reversedUserText.Length - 1; i++)
            {
                reversedWords += reversedUserText[i] + ' ';
            }
            Console.WriteLine("Reversed words are:");
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(reversedWords);
            return reversedWords;
        }
        
        Console.WriteLine("Enter your words which need to reverse:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        var userTextInConsole = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userTextInConsole))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: input text is empty or null. Please, write words which need to reverse");
            return null;
        }
        
        var reversedTextInConsole = userTextInConsole.Split(' ');
        Array.Reverse(reversedTextInConsole);
        
        for (var i = 0; i <= reversedTextInConsole.Length - 1; i++)
        {
            reversedWords += reversedTextInConsole[i] + ' ';
        }
        
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n Reversed words are:");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(reversedWords);

        return reversedWords;
    }
}