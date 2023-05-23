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
    if (num > 0)
    {
        for (int i = 2; i <= num; i++)
        {
            sum *= i;
        }
        return sum;
    }
    else if(num == 0)
    {
        return 0;
    }
    else
    {
        for(int i = -1; i >= num; i--)
        {
            sum *= i;
        }
        return sum;
    }
}

int number = Prompt();
Console.WriteLine($"{number} --> {FindMultiplication(number)}");
 
 // Эту задачу также можно решить путем использования третего метода, который будет добавлять минус перед числом, 
 // если оно отрицательное и нечётное
 
  

