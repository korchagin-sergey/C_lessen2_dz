// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите  число соотвецтвующее дню недели от 1 до 7: "); 
int dayNumber = Convert.ToInt32(Console.ReadLine()); 

string weekDay = "NO";
string WeekDay(int num) 
{
    if (num <= 0 || num > 7) 
    {
        Console.WriteLine("ВВедена неправильная цифра дня недели "); 
    }
    if (num == 1)
    {
        weekDay = "Понедельник"; // присвоение дня недели 7 раз
    }
    if (num == 2)
    {
        weekDay = "Вторник";
    }
    if (num == 3)
    {
        weekDay = "Среда";
    }
    if (num == 4)
    {
        weekDay = "Четверг";
    }
    if (num == 5)
    {
        weekDay = "Пятница";
    }
    if (num == 6)
    {
        weekDay = "Суббота это выходной день!";
    }
    if (num == 7)
    {
        weekDay = "Воскрсенье это выходной день!";
    }
    return  weekDay; 
}
Console.WriteLine($"{dayNumber} 'день недели' {WeekDay(dayNumber)}"); 