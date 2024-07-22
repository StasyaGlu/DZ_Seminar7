// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны 
// два неотрицательных числа m и n.


void Main()
{
    int m = ReadInt("Введите неотрицательное число m: ");
    int n = ReadInt("Введите неотрицательное число n: ");
    int result = A(m, n);
    System.Console.WriteLine(result);
}

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return A(m - 1, 1);
    else 
        return A(m - 1, A(m, n - 1));
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();