//задача19
Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000||n > 99999) 
{
Console.WriteLine("Вы ввели недопустимое число, повторите ввод:");
n = Convert.ToInt32(Console.ReadLine());
}
string result = Palidrome (n)? $"Число {n} является полидромом" : $"Число {n} не является полидромом";
Console.WriteLine(result);

bool Palidrome (int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num3 = num / 10 % 10;
    int num4 = num % 10;

    return num1 == num4 && num2 == num3; 
}