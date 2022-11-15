// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размерность массива");
int column = Convert.ToInt32(Console.ReadLine()); int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите интервал значений массива");
int numbersInterval = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[column, line];

FillArray(array, numbersInterval);
Console.WriteLine("Созданный массив");
PrintArray(array);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + FindLineWithMinSum(array));

void FillArray(int[,] array, int numbersInterval)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, numbersInterval);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindLineWithMinSum(int[,] array)
{
    int summ = 0;
    int minSumm = 0;
    int lineWithMinSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            summ = summ + array[i, j];
        }

        Console.Write(summ);
        Console.Write(" ");

        if (i == 0)
        {
            minSumm = summ;
            lineWithMinSum = 1;
        }
        if (summ < minSumm)
        {
            minSumm = summ;
            lineWithMinSum = i + 1;
        }
        summ = 0;
    }
    return lineWithMinSum;
}