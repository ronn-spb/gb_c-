﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int N = 8;
static void NaturalNumber(int n)
{
    if (n == 0)
        return;
    Console.WriteLine(n);
    NaturalNumber(n - 1);
}
NaturalNumber(N);