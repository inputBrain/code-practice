namespace CodePractice.Reverse;

public class ReverseText
{
    public static string? ReverseWords()
    {
        var reversedWords = string.Empty;

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
        Console.WriteLine("Reversed words are:");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(reversedWords);

        return reversedWords;
    }

    
    public static string? ReverseWords(string? text)
    {
        var reversedWords = string.Empty;
        
        if (string.IsNullOrWhiteSpace(text))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: input text is empty or null. Please, pass words which need to reverse");
            return null;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Your text is: \n{text}");
    
        var reversedUserText = text.Split(' ');
        Array.Reverse(reversedUserText);


        for (var i = 0; i <= reversedUserText.Length - 1; i++)
        {
            reversedWords += reversedUserText[i] + ' ';
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Reversed words are:");
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(reversedWords);
        return reversedWords;
    }
}