/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

Console.WriteLine("Укажите количество строк и столбцов в двумерном массиве.");
Console.Write("Введи m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] realArray = new double[m, n];

Console.WriteLine();

for (int k = 1; k < n + 1; k++)
{
    Console.Write(k + "\t");
}

Console.WriteLine();

for (int k = 1; k < n + 1; k++)
{
    Console.Write("————————");
}

Console.WriteLine();

for (int i = 0, k = 1; i < m; i++, k++)
{
    for (int j = 0; j < n; j++)
    {
        realArray[i, j] = (new Random().NextDouble() * 15);
        Console.Write(Math.Round(realArray[i, j], 2) + "\t");
    }
    Console.Write("|" + k);
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Оки, а теперь введи строку и столбец, покажу тебе какое там значение.");
Console.Write("Введи m:");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи n:");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= m && column <= n)
{
    Console.ForegroundColor = ConsoleColor.Green;  
    Console.WriteLine($"Точное неокруглённое значение элемента в позиции ({row};{column}) : {realArray[row-1, column-1]} ");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Really Nigga? Я был уверен что максимальный ряд {m}, а строка {n}");
    Console.ResetColor();
}