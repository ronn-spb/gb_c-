//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = 3;
int n = 8;

int Ackermann(int m, int n)
{
    if (m == 0)
        return (n + 1);
    if (n == 0)
        return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}
int result = 0;
result = Ackermann(m, n);
Console.WriteLine($"Результат функции Аккермана чисел {m} и {n}: {result}");