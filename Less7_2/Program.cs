﻿//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Двумерный массив.
int[,] array = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 4 || y > 4)
{
    Console.WriteLine("Такого элемента нет.");
}
else
{
    Console.WriteLine("Элемент со значением {0} находится по указанным координатам.", array[x, y]);
}