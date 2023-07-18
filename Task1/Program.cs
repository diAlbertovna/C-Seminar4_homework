// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// 


// int GetInfo(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }    
// int num = GetInfo("Enter number: ");
// Console.Write($"{Sum(num)}");


int Sum(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}    
int num = GetInfo("Enter number: ");
Console.Write($"{Sum(num)}");
