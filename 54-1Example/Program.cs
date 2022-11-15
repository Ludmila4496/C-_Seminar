// Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).

Console.WriteLine("Введите размерность массива");
int column = Convert.ToInt32(Console.ReadLine()); int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите интервал значений массива");
int numbersInterval = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[column, line];
int[] simpleArray = new int[column * line];

FillArray(array, numbersInterval);
Console.WriteLine("Первоначальный массив");
PrintArray(array);
ConvertToSimpleArray(array, simpleArray);
SortArray(simpleArray);
ConvertToInitialArray(simpleArray, array, column, line);
Console.WriteLine("Отсортированный массив");
PrintArray(array);

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

void ConvertToSimpleArray(int[,] array, int[] simpleArray)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            simpleArray[k] = array[i, j];
            k = k + 1;
        }
    }

}

void SortArray(int[] simpleArray)
{
    int temp = 0;
    {
        for (int i = 0; i < simpleArray.Length; i++)
        {
            for (int k = 0; k < simpleArray.Length; k++)
            {
                if (simpleArray[i] > simpleArray[k])
                {
                    temp = simpleArray[i];
                    simpleArray[i] = simpleArray[k];
                    simpleArray[k] = temp;
                }
            }
        }

    }
}

void ConvertToInitialArray(int[] simpleArray, int[,] array, int column, int line)
{
    int k = 0;
    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < line; j++)
        {

            array[i, j] = simpleArray[k];
            k = k + 1;
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