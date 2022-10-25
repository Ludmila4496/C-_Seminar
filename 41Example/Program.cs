// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целые числа через пробел");
string number = Console.ReadLine();
string[] splitNumber = number.Split(' ');    //Разделить строку по пробелу
int[] Number = convertArray(splitNumber);    //Преоброзавать элементы массива в числа
PrintArray(Number);
int amount = positiveNumber(Number);
Console.Write($"В данном массиве {amount} положительных числа");

int[] convertArray(string[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = Convert.ToInt32(arr[i]);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] ");
}

int positiveNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count; 
}