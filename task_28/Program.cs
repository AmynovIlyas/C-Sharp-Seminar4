// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
// Например:
// 4 --> 24
// 5 --> 120

int Prompt()
{
    Console.WriteLine("Введите число N: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int FindMultiplication(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    {
        sum *= i;
    }
    return sum;
}

int number = Prompt();
Console.WriteLine($"{number} --> {FindMultiplication(number)}");


