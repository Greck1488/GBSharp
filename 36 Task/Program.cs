/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

Console.WriteLine("Cколько в массиве должно быть чисел?");
int Count = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Count];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)

    arr[i] = rand.Next(-100, 100);

int sumValue = 0;

for (int i = 1; i < arr.Length; i++)

    if (i % 2 != 0)
    {
        sumValue += arr[i];
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine(arr[i]);
        Console.ResetColor();
    }

Console.ForegroundColor = ConsoleColor.DarkYellow; 
Console.WriteLine($"[{String.Join("; ", arr)}]");
Console.ForegroundColor = ConsoleColor.DarkGreen; 
Console.WriteLine($"Сумма элементов на нечётных позициях = {sumValue}");
Console.ResetColor();