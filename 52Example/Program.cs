// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Введите высоту массива");
int m = CorrectNaturalNumber();
Console.WriteLine("Введите ширину массива");
int n = CorrectNaturalNumber();
Console.WriteLine();

double[,] arr = new double[m + 1, n];

NewArray(arr, m);
AverageColumns(arr, m);
PrintArray(arr, m + 1);

void NewArray(double[,] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10) + new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
        if ((i == (array.GetLength(0)-2)) && (array.GetLength(0) == size)) Console.WriteLine("Среднее арифметическое по столбцам:");
    }
    Console.WriteLine();
}

void AverageColumns(double[,] array, int size)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j, i];
            if (j == size - 1) array[j + 1, i] = average / (size);
        }
    }
 }

    int CorrectNaturalNumber()
    {
        string value = "";
        int number = 0;
        while (true)
        {
            value = Console.ReadLine();
            try
            {
                number = int.Parse(value);
            }
            catch
            {
                Console.WriteLine("ОШИБКА! Вы ввели не натуральное число, повторите ввод: ");
                continue;
            }
            if (number < 1)
            {
                Console.WriteLine("ОШИБКА! Вы ввели число меньше 1, повторите ввод: ");
                continue;
            }
            return number;
        }
    }