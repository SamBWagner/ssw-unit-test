Console.Write("Enter a number:");

var input = Console.ReadLine();

if (input is not null)
{
    var number = int.Parse(input);
    Console.WriteLine($"{number} multiplied by itself is {number * number}");
}