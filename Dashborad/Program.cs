using static System.Console;

WriteLine("== Start Calculation");

var kernel = new Kernel.KCore();
double a = 6, b = 2.5;

ForegroundColor = ConsoleColor.Cyan;
WriteLine($"{a} + {b} = {kernel.Add(a, b)}");

ForegroundColor = ConsoleColor.DarkYellow;
WriteLine($"{a} - {b} = {kernel.Subtract(a, b)}");

ForegroundColor = ConsoleColor.Yellow;
WriteLine($"{a} * {b} = {kernel.Multiple(a, b)}");

ResetColor();
WriteLine("== End Calculation");
