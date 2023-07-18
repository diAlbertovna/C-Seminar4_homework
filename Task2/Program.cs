// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] MakeNewArray(int length)
{
    int[] array = new int [length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    { 
        array[i] = random.Next(0,101);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    Console.Write($"{array[i]}, ");
}
int length = 8;
int[] array = MakeNewArray(length);
PrintArray(array);


