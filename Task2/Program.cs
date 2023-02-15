// Показать натуральные числа от M до N, N и M заданы

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


void Rec(int m, int n)
{
    if (n < m) return;
    Rec(m, n - 1);
    Console.WriteLine(n);
}

int m =ReadInt("Введите число M ");
int n =ReadInt("Введите число N ");
Rec(m, n);
