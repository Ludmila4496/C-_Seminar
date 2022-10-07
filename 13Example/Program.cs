// //задача13 число справа
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n / 100 == 0) Console.WriteLine("третьей цифры нет");
// else Console.WriteLine(n % 1000 / 100);

//задача13 число слева
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length > 2) {
    Console.WriteLine("третьей цифра " + number_text[2]);    
}
else {
    Console.WriteLine("третьей цифры нет");
}