// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> такого элемента в массиве нет

Console.WriteLine("Введите высоту массива");
int m = CorrectNaturalNumber();
Console.WriteLine("Введите ширину массива");
int n = CorrectNaturalNumber();

int[,] arr = new int[m, n];
NewArray(arr);
PrintArray(arr);

Console.WriteLine("Введите позицию элемента через пробел");
string poz = Console.ReadLine();
string[] splitPoz = poz.Split(' '); 
int line = Convert.ToInt32(splitPoz[0]);
int column = Convert.ToInt32(splitPoz[1]);

try
{
    Console.WriteLine($"Элемент на позиции [{line},{column}] это: {arr[line,column]}");
}
catch
{
    Console.WriteLine($"Позиция [{line},{column}] выходит за рамки массива");
}


void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 99);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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