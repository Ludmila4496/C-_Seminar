//задача10
Console.WriteLine("Введите трехзанчное число");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100|n > 999) 
{
Console.WriteLine("Вы ввели недопустимое число, повторите ввод:");
n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вторая цифра числа " + Convert.ToString(n/10%10));