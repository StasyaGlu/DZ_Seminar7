// Задайте значение M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке
// от M до N. Рекурсия.

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N (больше M): ");
    PrintNumber(M, N);
}

void PrintNumber(int arg, int N)
{
    if(N < arg) return;
    
    System.Console.Write(arg + " ");
    PrintNumber(arg + 1, N);
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
