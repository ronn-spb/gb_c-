//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] arrayNumbers = { 1.2, 3.4, 11.6, 7.8, 9.0 };
double min = arrayNumbers[0];
double max = arrayNumbers[0];
for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (arrayNumbers[i] > max)
    {
        max = arrayNumbers[i];
    }
    else if (arrayNumbers[i] < min)
    {
        min = arrayNumbers[i];
    }
}
double difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементам массива составляет: {0} ", difference);