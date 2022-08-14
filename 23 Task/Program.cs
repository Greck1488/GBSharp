/* 
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. */

Console.WriteLine("Введи число до которого тебе интересно рассчитать таблицу кубов");
int Number = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=Number; i++)
{
    double NumberX3 = Math.Pow(i,3);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(NumberX3 + "\t");
    Console.ResetColor();
}

