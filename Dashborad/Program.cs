Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("= Start Calculation");

var kernel = new Kernel.KCore();
double a = 3.5, b = 2.5;
Console.WriteLine($"{a} + {b} is {kernel.Add(a, b)}");

Console.WriteLine("== End Calculation");
Console.ResetColor();
