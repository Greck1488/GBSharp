/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число:"); 
int num1 = Convert.ToInt32(Console.ReadLine()); // Ввод первого числа

Console.WriteLine("Введите второе число:"); 
int num2 = Convert.ToInt32(Console.ReadLine()); // Ввод второго числа

int max = Math.Max(num1, num2); // Математическая функция нахождения максимума
int min = Math.Min(num1, num2); // Математическая функция нахождения минимума
Console.WriteLine("Максимальное число: " + max); // Вывод результата на экран
Console.WriteLine("Минимальное число: " + min); // Вывод результата на экран