void DayOff(int number)
{
    if(number == 1) Console.WriteLine($"Понедельник");
    if(number == 2) Console.WriteLine($"Вторник");
    if(number == 3) Console.WriteLine($"Среда");
    if(number == 4) Console.WriteLine($"Четверг");
    if(number == 5) Console.WriteLine($"Пятница");
    if(number == 6) Console.WriteLine($"Суббота - выходной день!!!");
    if(number == 7) Console.WriteLine($"Воскресенье - выходной день!!!");
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
DayOff(num);
