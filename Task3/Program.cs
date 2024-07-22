// Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. 
// Использовать рекурсию, не использовать 
// циклы.


void Main() 
{ 
    int arraySize = ReadInt("Введите размер массива: "); 
    int[] array = GenerateArray(arraySize, 0, 9);
    PrintArray(array);
 
    PrintArrayReverse(array, array.Length - 1); 
    
} 
 
void PrintArrayReverse(int[] arr, int i) 
{ 
    if (i >= 0) 
    { 
        Console.Write(arr[i] + " "); 
        PrintArrayReverse(arr, i - 1); 
    } 
} 

void PrintArray(int[] arrayForPrint) 
{
    System.Console.WriteLine(string.Join(", ", arrayForPrint));
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue + 1);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();