﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Только для целых чисел, в том числе и отрицательных

Console.WriteLine("Введите число");
int day = int.Parse(Console.ReadLine()!);

int x = 8;
int y = 6;    // Эти переменные для создания условий, где нужно сравнивать, чтобы оставить только числа в промежутке от 1 до 7 включительно,
int z = 1;    // а также создать условие, где вводимые числа остаются за пределами этого промежутка

int a = 2;    // Эти переменные для обозначения дней недели, чтобы их можно было подвязать и вывести вместе с числом и проверкой,
int b = 3;    // является ли этот день выходным, например:
int c = 4;    // 1 --> понедельник, не выходной
int d = 5;    // 6 -- > суббота, выходной
int e = 7;    // 8 -- > это число не является обозначением дня недели

if (day < y && day >= z)
    
    {
        if(day == z)
        {
        Console.WriteLine("Понедельник");
        Console.WriteLine("Не выходной");
        }

        if(day == a)
        {
        Console.WriteLine("Вторник");
        Console.WriteLine("Не выходной");
        }

        if(day == b)
        {
        Console.WriteLine("Среда");
        Console.WriteLine("Не выходной");
        }

        if(day == c)
        {
        Console.WriteLine("Четверг");
        Console.WriteLine("Не выходной");
        }

        if(day == d)
        {
        Console.WriteLine("Пятница");
        Console.WriteLine("Не выходной");
        }
    }    

if (day >= y && day < x)

    {
        if(day == y)
        {
        Console.WriteLine("Суббота");
        Console.WriteLine("Выходной");
        }

        if(day == e)
        {
        Console.WriteLine("Воскресенье");
        Console.WriteLine("Выходной");
        }
    }

if (day < z || day >= x)

    {
        Console.WriteLine("Это число не является обозначением дня недели");
    }
  