//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите число соответствующее дню недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
while(numberDayOfWeek<1||numberDayOfWeek>7)
{
    Console.WriteLine("Число неверное.");
    Console.WriteLine("Введите число соответствующее дню недели: ");
}if(numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник --> нет - не выходной день, а рабочий.");
}if(numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник --> нет - не выходной день, а рабочий.");
}if(numberDayOfWeek == 3)
{
    Console.WriteLine("Среда --> нет - не выходной день, а рабочий.");
}if(numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг --> нет - не выходной день, а рабочий.");
}if(numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница --> нет - не выходной день, а рабочий.");
}if(numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота --> ДА - выходной день.");
}if(numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье --> ДА - выходной день.");
}