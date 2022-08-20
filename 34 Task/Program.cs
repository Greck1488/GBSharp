/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

Console.WriteLine("Cколько в массиве должно быть чисел?");
int Count = Convert.ToInt32(Console.ReadLine());
int SumIndex = 0;
int[] arr = new int[Count];
Random rand = new Random();
for(int i =0;i<arr.Length;i++)
{
arr[i] = rand.Next(100,999);
    if (arr[i] % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine(arr[i]);
        SumIndex += 1;
    } 
    else
    {
        Console.ResetColor();
    }
    Console.ResetColor();
}
Console.WriteLine($"Количество чётных чисел в массиве {SumIndex}");