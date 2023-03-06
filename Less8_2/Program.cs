//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = {{1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}};

int minSum = int.MaxValue;
int minRow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minRow = i;
    }
}
Console.WriteLine($"Row with minimum sum: {minRow}, Sum: {minSum}");