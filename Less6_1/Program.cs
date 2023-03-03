//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int count = 0;
Console.WriteLine("Введите количество чисел:");
int M = Int32.Parse(Console.ReadLine());
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число:");
    int number = Int32.Parse(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел, больше 0: " + count);