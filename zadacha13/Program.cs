// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите  трехзначное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num = num2;

double rezult = 0;

if (num2 <= 99)
{
    Console.WriteLine("не правильно введено число ");
}
else
{
    for (int i = 0; i < num2; i++)
    {
        if (num2 < 10000)
        {
            double num1 = ((num2 % 100) / 10);
            rezult = Math.Round(num1, 1);
        }
        if (num2 >= 10000)
        {
            num2 = num2 / 10;
        }
    }
}
if (rezult >= 0)
{
    Console.WriteLine($"В веденном числе третье  {rezult}");
}
