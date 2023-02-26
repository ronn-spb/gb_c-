
int ReadNumberFormConsole(string title)
{

    Console.WriteLine(title);
    if (Int32.TryParse(Console.ReadLine(), out int result))
    {
        return result;
    }
    return -1;
}

int PowNumber(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}
int numberA = 0, numberB = 0;

numberA = ReadNumberFormConsole("Введите число А: ");
numberB = ReadNumberFormConsole("Введите число B: ");

Console.WriteLine(PowNumber(numberA, numberB));





