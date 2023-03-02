int n = InputInt("Введите число больше 0: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Вы ввели отрицательное число");
}
Console.WriteLine(N(n, m));

int N(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{N(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}