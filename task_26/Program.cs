// Напишите программу, которая принимает на вход число и выдаёт количетсво цифр в числе
// Например:
// 456 --> 3
// 78 --> 2
// 89126 --> 5

int Prompt()
{
    Console.WriteLine("Введите число: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

int HowManyNumber(int num)
{
    int count = 0;
    if (num != 0)
    {
        while (num > 0 || num < 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
    return 1;
}

int number = Prompt();
Console.WriteLine($"{number} --> {HowManyNumber(number)}");

