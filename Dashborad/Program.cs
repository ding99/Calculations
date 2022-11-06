Console.WriteLine("= Start Calculation");

var kernel = new Kernel.KCore();

Console.ForegroundColor = ConsoleColor.Cyan;
double a = 3.5, b = 4;
Console.WriteLine($"{a} + {b} is {kernel.Add(a, b)}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{a} * {b} is {kernel.Multiple(a, b)}");

Console.ResetColor();
Console.WriteLine("== End Calculation");
