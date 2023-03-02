int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {Summ(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Summ(int m, int n)
{
    if (m == n)
        return n;
    return n + Summ(m, n - 1);
}
