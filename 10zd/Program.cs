//Задание 10
int SecNumber (int number)
{

    int n1 = (number / 10) % 10;
    return n1;
}
int randNumber = new Random().Next(100, 1000);
int secnum = SecNumber(randNumber);

Console.WriteLine($"Secnumber of {randNumber} is {secnum}");