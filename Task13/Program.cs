// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Введите число");      // Есть возможно задавать и отрицательные числа
int num = int.Parse(Console.ReadLine()!);

while (num > 1000 | num < -999)
{
    num = num / 10;
}

if (num < 1000 && num > 99 )
{
    int a = num % 10;
    Console.WriteLine(a);
}

if (num > -1000 && num < -99)
{
    num = -num;
    int a = num % 10;
    Console.WriteLine(a);
}

if (num < 100 && num > -100)
{
    Console.WriteLine("третьей цифры нет");
}
