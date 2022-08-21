/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. */

Console.Write("Какое число элементов нужно в массиве? ");
int num = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[num];
double result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.NextDouble();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(numbers[i] + "\t");
    Console.ResetColor();
}

result = numbers.Max() - numbers.Min();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nРазница между максимальным числом массива и минимальным: {result}");
Console.ResetColor();