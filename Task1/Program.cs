// Показать натуральные числа от N до 1, N задано

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void rec (int n)
{
    if(n==0) return;    
    Console.WriteLine(n);
    rec(n-1);
}
int n =ReadInt("Введите число N ");
rec(n);