// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// $a=['my','name','is','john','doe'];


using CodePractice;

void GetShortestWord(string[] words)
{
    // var ww = words.OrderBy(x => x.Length).First();
    //
    // Console.WriteLine(ww);

    var shortestWord = string.Empty;
    
    for (var i = 0; i < words.Length; i++)
    {
        if (shortestWord.Length < words[i].Length)
        {
            continue;
        }
        shortestWord = words[i];
    }

    Console.WriteLine(shortestWord);
}

var dbList = new List<string>{"1", "don't", "2", "3", "hello"};
var includeWords = new List<string>{"1", "2", "3", "4", "5"};
var excludeWords = new List<string> {"Don't", "2", "5", "hello"};
// GetShortestWord(words);


static void EnsureString(IEnumerable<string> includeWords, IEnumerable<string> excludeWords)
{
    var preparedCollection = includeWords.Except(excludeWords);
    foreach (var excludeWord in preparedCollection)
    {
            Console.WriteLine(excludeWord);
    }

}

// EnsureString(includeWords, excludeWords);



// Ff();

 // static void Ff()
// {
    // var totalSpend = 0;

    // for (var i = 0; i <= 210; i++)
    // {
        // totalSpend += i * 10;
    // }

    // Console.WriteLine(totalSpend);
// }

var numList = new List<int>() {11, 18, 25, 13, 19, 11, 1, 2, 1, 22, 15, 22, 14, 1};
    
    var alp = Factory.AlphabetPosition();
    alp.TextToAlphabetPositions("php");
    