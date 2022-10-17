// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num];

void NewArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
    }
}

void PrintArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");
    }
    Console.WriteLine();
}

int CountEven(int[]array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count = count + 1;
    }
    return count;
}
NewArray(arr);
PrintArray(arr);
int SumCount = CountEven(arr);
Console.WriteLine($"Количество чётных чисел в массиве {SumCount}");