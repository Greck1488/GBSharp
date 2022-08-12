/*
 Задача 15: Напишите программу, которая принимает на вход цифру, 
 обозначающую день недели, и проверяет, является ли этот день выходным.
 */

Console.WriteLine("Введите цифру дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7) { Console.WriteLine("Chill Out. Сегодня выходной"); }
else if (dayNumber > 7) { Console.WriteLine($"Доброе утро! Какие нафиг {dayNumber} дней в неделе?! Исправься!"); }
else if (dayNumber < 1) { Console.WriteLine("Я для тебя что, шутка?? Исправь быстро!!"); }
else { Console.WriteLine("Иди работать салага, команды отдыхать не было."); }