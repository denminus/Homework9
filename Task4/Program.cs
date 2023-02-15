// Написать программу вычисления функции Аккермана

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Akker(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akker(n - 1, 1);
    else
      return Akker(n - 1, Akker(n, m - 1));
}
int m =ReadInt("Введите число M ");
int n =ReadInt("Введите число N ");
Console.WriteLine(Akker(n, m));

