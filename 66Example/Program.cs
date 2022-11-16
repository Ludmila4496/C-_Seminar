// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число m: ");
int m = CorrectNaturalNumber();

Console.Write("Введите число n: ");
int n = CorrectNaturalNumber();

SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

int CorrectNaturalNumber()                                       //метод проверки размерности массива
{
    string value="";
    int number=0;
    while (true)
    {
        value=Console.ReadLine();
        try 
        {
            number=int.Parse(value);
        }
        catch
        {
            Console.Write ("ОШИБКА! Вы ввели не натуральное число, повторите ввод: ");
            continue;
        }
        if (number<1) 
        {
            Console.Write ("ОШИБКА! Вы ввели число меньше 1, повторите ввод: ");
            continue;
        }
        return number;
    }
} 