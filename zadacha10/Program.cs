// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear(); 
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
double second(int number)
{
    double result2 = 1; 
    if (number < 100 || number > 1000) 
    {
        Console.WriteLine("Ошибка: Введите трехзначное число");  
    }
    else
    {
        double result = number / 10; 
        result2 = Math.Round(result, 1) % 10;
    }
    return result2;
}
Console.WriteLine(second(num)); 