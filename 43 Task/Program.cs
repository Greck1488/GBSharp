/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. */
Console.WriteLine("Есть два уравнения:");
Console.WriteLine("Первое: y = k1 * x + b1");
Console.WriteLine("Второе: y = k2 * x + b2");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Задача такая, мы ищём точку пересечениях прямых. Все значения - твоё творчество!");
Console.ResetColor();

Console.Write("Введи b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Смотри, первое уравнение теперь выглядит так:");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"y = {k1} * x + {b1}");
Console.ResetColor();

Console.Write("Введи b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Смотри, второе уравнение теперь выглядит так:");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"y = {k2} * x + {b2}");
Console.ResetColor();

Console.WriteLine("Итак, найдём же точку пересечений.");
float x = (float) (b2 - b1) / (k1 - k2);
float y = (float) k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine("Готово!");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Точкой пересечения данных двух прямых является координата ({x};{y})");
Console.ResetColor();