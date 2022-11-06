using static System.Console;

WriteLine("== Start Calculation");

var kernel = new Kernel.KCore();
double a = 4, b = 2.5;

ForegroundColor = ConsoleColor.Cyan;
WriteLine($"{a} + {b} is {kernel.Add(a, b)}");

ForegroundColor = ConsoleColor.DarkYellow;
WriteLine($"{a} - {b} is {kernel.Subtract(a, b)}");

ForegroundColor = ConsoleColor.Yellow;
WriteLine($"{a} * {b} is {kernel.Multiple(a, b)}");

ResetColor();
WriteLine("== End Calculation");
