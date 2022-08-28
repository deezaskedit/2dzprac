void ThirdNumber(int number)
{
    if(number >= 100 ^ number <= -100)
    {
        int current = number;
        int output = 0;
        while(current > 1000 ^ current < -1000)
        {
            current /= 10;
        }
        output = current % 10;
        if (output < 0) output = output * (-1);
        Console.WriteLine($"Третья цифра введенного числа это {output}");

    }
    else
    {
        Console.WriteLine("Введите трехзначное число или больше");
    }
}
Console.WriteLine("Введите число");
int inputnum = Convert.ToInt32(Console.ReadLine());
ThirdNumber(inputnum);