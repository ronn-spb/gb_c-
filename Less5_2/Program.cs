//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Random random = new Random();
int[] arrayNumbers = new int[10];
int sumEven = 0;
for (int i = 0; i < arrayNumbers.Length; i++)
{
    arrayNumbers[i] = random.Next(1, 100);
    if (i % 2 != 0)
    {
        sumEven += arrayNumbers[i];
    }
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: {0}", sumEven);