// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
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
    int s = num * (num + 1) / 2;
    return s;
}

int number = Prompt("Введите число: ");
int summa = FindS(number);

if(number >= 0)
{
    Console.WriteLine($"{number} --> {summa}");
}
else
{
    Console.WriteLine("Введенное число - отрицательное");
}
