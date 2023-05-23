// Напишите программу,которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}

// можно сделать иначе: вызывать метод и вводить число, равное количеству элементов в массиве
// int FillArray(int collection)
// {
//     int[] arr = new int[collection];
//     for(int i = 0; i < collection; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

void PrintArray(int[] collection)
{
    int length = collection.Length;
    Console.Write("{");
    for(int i = 0; i < length - 1; i++)
    {
        Console.Write($"{collection[i]}, ");
    }
    Console.Write($"{collection[length - 1]}" + "}");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
