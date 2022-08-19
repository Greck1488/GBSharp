/*  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */
Console.WriteLine("Введите число, сумму цифр которого нужно посчитать");
int Number = int.Parse(Console.ReadLine());
    int sum = 0;
    while (Number > 0)
    {
        sum = sum + Number % 10;
        Number = Number/10;
    }
Console.ForegroundColor = ConsoleColor.Green;  
Console.WriteLine(sum);
Console.ResetColor();