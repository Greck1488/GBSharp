//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("Укажите два числа. m - строки. n - столбцы.");
Console.Write("Введи m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] realArray = new double[m, n];
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        realArray[i, j] = (new Random().NextDouble() * 15);
        Console.Write(Math.Round(realArray[i, j], 2) + "\t");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Ну как матрица? Понравилась?");
Console.ResetColor();