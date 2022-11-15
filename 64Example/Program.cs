// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число");
int number = CorrectNaturalNumber();

printNaturalNumbers(number); 

void printNaturalNumbers(int n){   
    int number = 1;
    if (n == number) {
        Console.Write ($"{n} ");
    }
    else {                              
        Console.Write ($"{n} ");         
        printNaturalNumbers(n - 1);    
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