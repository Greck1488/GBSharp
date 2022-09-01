/* Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[ , ] matrix = new int [rows,columns];

Console.WriteLine("Заданная матрица");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.ResetColor();


Console.WriteLine("Итоговая матрица");
Console.ForegroundColor = ConsoleColor.DarkGreen;
for (int i = 0; i < rows; i++)
{
    int[] array = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        array[j] = matrix[i,j];
        Array.Sort(array);
        Array.Reverse(array);
    }
    Console.WriteLine(String.Join("\t", array));
    Console.WriteLine();
}
Console.ResetColor();
