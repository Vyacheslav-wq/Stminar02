﻿//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да
// символ: || означает "или"; Символы: && означает "и".
// ((a||c)&&(d||v))

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"{num} --> ДА.");
}
else
{
    Console.WriteLine($"{num} --> НЕТ.");
}