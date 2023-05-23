// Напишите программу, которая принимает на вход число и выдаёт количетсво цифр в числе
// Например:
// 456 --> 3
// 78 --> 2
// 89126 --> 5

string Prompt()
{
    Console.WriteLine("Введите число: ");
    string result = Console.ReadLine();
    return result;
}

int HowManyNumber(string num)
{
    int count = 0;
    int tmp = 0;
    for (int i = 0; i < num.Length; i++)
    {
        tmp = num[i];
        count++;
    }
    int numb = Convert.ToInt32(num);
    if (numb < 0)
    {
        return count - 1;
    }
    else
    {
        return count;
    }
}

string number = Prompt();
Console.WriteLine($"{number} --> {HowManyNumber(number)}");

