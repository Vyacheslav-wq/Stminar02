//Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
//918 = 9 * 100 + 1 * 10 + 8
//98 = 9 * 10 + 8 
Console.Clear();
int num = new Random().Next(100, 1000);
int result = (num / 100) * 10 + num%10;
Console.WriteLine($"{num} --> {result}");

//Второй метод решения этой задачи.
// Console.Clear();
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"{num} --> {num/100}{num%10}");