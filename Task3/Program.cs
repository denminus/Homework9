// Найти сумму элементов от M до N, N и M заданы

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int Rec(int m, int n)
{   
    if (n == m) return n;
    return m+Rec(m+1,n);
        
}

int m =ReadInt("Введите число M ");
int n =ReadInt("Введите число N ");

//Rec(m, n);
Console.WriteLine(Rec (m,  n));