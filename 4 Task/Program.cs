/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа ");
int num1 = Convert.ToInt32(Console.ReadLine()); // Ввод числа 1
int num2 = Convert.ToInt32(Console.ReadLine()); // Ввод числа 2
int num3 = Convert.ToInt32(Console.ReadLine()); // Ввод числа 3

int max = Math.Max(num1, Math.Max(num2, num3)); // Функция определения максимума
Console.WriteLine("Максимальное число: " + max); // Вывод результата в консоль