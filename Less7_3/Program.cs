//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = new int[,] { { 1, 4, 7 }, { 3, 8, 4 }, { 8, 2, 3 } };

double sum1 = 0;
double sum2 = 0;
double sum3 = 0;
double avg1, avg2, avg3;
for (int i = 0; i < 3; i++)
{
    sum1 += array[i, 0];
    sum2 += array[i, 1];
    sum3 += array[i, 2];
}
avg1 = sum1 / 3;
avg2 = sum2 / 3;
avg3 = sum3 / 3;
Console.WriteLine($"Среднее арифметическое элементов 1 столбца = {avg1}");
Console.WriteLine($"Среднее арифметическое элементов 2 столбца = {avg2}");
Console.WriteLine($"Среднее арифметическое элементов 3 столбца = {avg3}");