// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите числа через пробел:");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int Count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) Count++;
}

Console.WriteLine($"Количество чисел больше нуля: {Count}");