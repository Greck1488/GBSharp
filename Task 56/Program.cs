/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int[ , ] matrix = new int [rows,columns];

Console.WriteLine("Матрица");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(10);
        Console.Write("\t" + matrix[i,j]);
    }
    Console.WriteLine();
}

int[] SumOfRow = new int[columns];

for (int i = 0; i < rows; i++)
{
    int sum = 0;
    int j;
    for (j = 0; j < columns; j++)
    {
        sum += matrix[i,j];
    }
    SumOfRow[i] = sum;
}
int minSumOfRow = Array.IndexOf(SumOfRow,SumOfRow.Min());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Строка номер {minSumOfRow + 1}, строка с минимальным значением суммы элементов!");
Console.ResetColor();