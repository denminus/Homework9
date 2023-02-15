// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Metod(int first, int second, int number)
{
    if (number == 1) return first;
    if (number == 2) return second;
    return Metod(first, second, number - 1) + Metod(first, second, number - 2);
}


int first =ReadInt("Введите первое число  ");
int second =ReadInt("Введите второе число ");
int n =ReadInt("Введите число N ");


for (int i = 1; i < n; i++)
{
    Console.WriteLine(Metod(first, second, i));
}



