// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Sum = SumNum(num);
Console.WriteLine(Sum);

int SumNum(int n)
{
    int Sum = 0;  

    while (n/10 != 0||n%10 != 0)
    {
        Sum += Convert.ToInt32(n%10);  
        n/=10;
    }
    return Sum;
}