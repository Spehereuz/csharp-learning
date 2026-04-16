Console.ForegroundColor = ConsoleColor.Red;

if (args.Length != 2)
{
    Console.WriteLine("Please provide exactly two numbers as arguments.");
    Environment.Exit(1);
}

if (!double.TryParse(args[0], out double num1))
{
    Console.WriteLine($"{args[0]} is not a number.");
    Environment.Exit(1);
}

if (!double.TryParse(args[1], out double num2))
{
    Console.WriteLine($"{args[1]} is not a number.");
    Environment.Exit(1);
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Operations with command line arguments:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{num1} + {num2} = {num1 + num2:f3}");
Console.WriteLine($"{num1} - {num2} = {num1 - num2:f3}");
Console.WriteLine($"{num1} * {num2} = {num1 * num2:f3}");

if (num2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Cannot divide by zero.");
}
else
{
    Console.WriteLine($"{num1} / {num2} = {num1 / num2:f3}");
}

Console.ResetColor();