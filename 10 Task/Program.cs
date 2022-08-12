/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Нужно сделать через числа, без индексов строк. 
*/

Console.WriteLine("Введите сюда трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999) { Console.WriteLine("Читать умеем? Надо ТРЁХЗНАЧНОЕ!"); Environment.Exit(0); }

int secondDigit = (num / 10) % 10;
Console.WriteLine("Вторая цифра:");
Console.WriteLine(secondDigit);