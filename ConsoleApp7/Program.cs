// See https://aka.ms/new-console-template for more informatf
double a = 0.7;
double b = 0.005;
double x = 0.5;
double r = 0;
double s = 0;

Console.WriteLine($"Число a = {a}");
Console.WriteLine($"Число b = {b}");
Console.WriteLine($"Число x = {x}");

r = Math.Pow(x, 2) * (x + 1) / b - Math.Pow(Math.Sin(x + a), 2);
Console.WriteLine($"Значение r = {r}");


s = Math.Sqrt(x * b / a) + Math.Pow(Math.Cos(x + b), 3);
Console.WriteLine($"Значение s = {s}");
