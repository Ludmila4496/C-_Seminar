//задача23

void CubeTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index,3}|{Math.Pow(index, 3),4}|");
        index++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);