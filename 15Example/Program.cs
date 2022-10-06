//задача15
Console.WriteLine("Введите день недели от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 | n > 7) 
{
Console.WriteLine("В неделе 7 дней, введите заново:");
n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6| n == 7) Console.Write("Ура выходной!!!");
else Console.WriteLine("Пашем негры, солнце еще высоко");