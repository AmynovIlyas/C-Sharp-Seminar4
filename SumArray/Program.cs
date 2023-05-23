// Сложение массивов

int[] RandArr(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int[] SumArray(int[] arr1, int[] arr2)
{
    int[] resArray = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        resArray[i] = arr1[i] + arr2[i];
    }
    return resArray;
}

void Print(int[] arr)
{
    Console.Write("{");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"[{arr[i]}], ");
    }
    Console.Write($"[{arr[arr.Length - 1]}]" + "}");
    Console.WriteLine();
}

const int lengthArr = 8;
int[] array1 = RandArr(lengthArr);
int[] array2 = RandArr(lengthArr);
Print(array1);
Print(array2);
Print(SumArray(array1, array2));

