/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
Console.WriteLine("Введите восемь чисел через пробел и нажмите Enter");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("Окей! Вы ввели следующие числа: ");
Console.ForegroundColor = ConsoleColor.Green; 
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("| " + numbers[i] + " |");
}
Console.ResetColor();