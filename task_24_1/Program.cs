// 2 вариант решения 24 задачи
// Напишите программуЮ которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 --> 28
// 4 --> 10
// 8 --> 36

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int FindS(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int number = Prompt("Введите число: ");
Console.WriteLine($"{number} --> {FindS(number)}");

