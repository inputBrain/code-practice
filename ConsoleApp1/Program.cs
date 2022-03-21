// See https://aka.ms/new-console-template for more information


// var numbers = new List<int>{1,3,8,0,1,3,6,7,15,2};
//
// foreach (var num in numbers.Where(x => x <= 5 & x >= 2).OrderBy(x => x).Distinct())
// {
//     Console.WriteLine(num);
// }
// // ----------------------
var random = new Random();
var numbers = new List<int>();

for (var i = 10; i < 5000; i++)
{
    var number = random.Next(1, i);
    numbers.Add(number);
}

foreach (var num in numbers.Where(x => x <= 200 | x >= 4500).OrderBy(x => x).Distinct())
{
    Console.WriteLine(num);
}