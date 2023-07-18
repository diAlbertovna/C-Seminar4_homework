// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Stepen(int num, int stepen)
{
       Console.Write(Math.Pow(num, stepen));
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Enter A: ");
int stepen = GetInfo("Enter B: ");
Stepen(num, stepen);