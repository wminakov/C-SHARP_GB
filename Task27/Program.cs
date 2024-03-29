﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение через цикл while
int SumDigits(int num)
{
    int sum = 0;
   while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

// Решение через цикл for
// int SumDigits(int num)
// {
//     int sum = 0;
//     if (num <= 0) num *= -1;
//     for (int i = 0; i != num + 1; i++)
//     {
//         sum += num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > -10 && number < 10)
{
    Console.WriteLine("Введите число, а не цифру.");
}
else
{
    int result = SumDigits(number) < 0 ? SumDigits(-number) : SumDigits(number);
    Console.WriteLine($"Сумма цифр в числе {number}: {result}");
}