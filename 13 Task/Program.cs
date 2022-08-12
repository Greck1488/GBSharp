/*
 Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string txtnum = Convert.ToString(num);

if (txtnum.Length > 2) { Console.WriteLine(txtnum[2]); }
else { Console.WriteLine("Третьей цифры просто нет :( "); }