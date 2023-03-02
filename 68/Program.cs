int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {AkkermanFunc(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunc(m - 1, 1);
    else
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}