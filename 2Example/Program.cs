//Задача2
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB) Console.WriteLine(numberA + " больше чем " + numberB);
else if (numberA == numberB) Console.WriteLine("Числа равны");
else Console.WriteLine(numberB + " больше чем " + numberA);