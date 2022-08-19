/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите cтепень, в которую необходимо возвести число");
int Degree = Convert.ToInt32(Console.ReadLine());

double NumberX3 = Math.Pow(Number,Degree);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(NumberX3 + "\t");
Console.ResetColor();