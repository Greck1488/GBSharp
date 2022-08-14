/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве. */

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Введи координаты точки X. (все три через пробел)");
Console.ResetColor();
int[] cord1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Введи координаты точки Y. (все три через пробел)");
Console.ResetColor();
int[] cord2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
double distance = Math.Sqrt(Math.Pow(cord2[0] - cord1[0], 2) + Math.Pow(cord2[1] - cord1[1], 2) + Math.Pow(cord2[2] - cord1[2], 2));

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(Math.Round(distance, 2));
Console.ResetColor();