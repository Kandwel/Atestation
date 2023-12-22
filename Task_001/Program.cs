//Задача 1: 
//Задайте значения M и N. Напишите
//программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не
//использовать циклы.

int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " ");
    PrintNumbers(M + 1, N);
}

int M = ReadInt("Введите меньшее число: ");
int N = ReadInt("Введите большее число: ");
PrintNumbers(M, N);
