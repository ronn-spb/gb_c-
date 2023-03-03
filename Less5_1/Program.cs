//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Random random = new Random();
int[] arryOfNumbers = new int[10];
int arrayCount = 10;
int countEvenNumbers = 0;
for (int i = 0; i < arrayCount; i++)
{
    arryOfNumbers[i] = random.Next(100, 1000);
    if (arryOfNumbers[i] % 2 == 0)
    {
        countEvenNumbers++;
    }
}
Console.WriteLine("Количество чётных чисел: {0}", countEvenNumbers);