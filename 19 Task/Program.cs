/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример палиндрома 12321 или 45054 */

Console.WriteLine("Введите пятизначное число");
string Numbers = Console.ReadLine();
string srebmuN = new string(Numbers.ToCharArray().Reverse().ToArray());  
if (Numbers == srebmuN)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Грац! Ты написал число палиндром.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Ты что, не знаешь что такое палиндром???");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("https://ru.wikipedia.org/wiki/Палиндром");
    Console.ResetColor();
}