// Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num];

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);
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
newArray(arr);
PrintArray(arr);