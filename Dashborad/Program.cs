using static System.Console;

WriteLine("== Start Calculation");

var kernel = new Kernel.KCore();
double a = 2.5, b = 4;

ForegroundColor = ConsoleColor.Cyan;
WriteLine($"{a} + {b} is {kernel.Add(a, b)}");

ForegroundColor = ConsoleColor.Yellow;
WriteLine($"{a} * {b} is {kernel.Multiple(a, b)}");

ResetColor();
WriteLine("== End Calculation");
