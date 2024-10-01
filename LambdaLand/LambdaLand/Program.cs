// See https://aka.ms/new-console-template for more information

List<int> numbers = 
new List<int>() { 9, 5, 15, 3, 4, 11, 7 };



// smallest
int smallestLINQ = numbers.Min();

// sum
int sumLINQ = numbers.Sum();

// odds only
var oddsLINQ = numbers.Where(x => x % 2 > 0).ToList();

// 3 smallest values
var smallestValsLINQ = numbers.OrderBy(x => x).Take(3);

Console.WriteLine(smallestLINQ);
Console.WriteLine(sumLINQ);
Console.WriteLine(oddsLINQ);
Console.WriteLine(smallestValsLINQ);
Console.ReadLine();