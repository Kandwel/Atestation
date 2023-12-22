//Задача 1: 
//Задайте значения M и N. Напишите
//программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не
//использовать циклы.

int M, N;

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

void EnterNum()
{
    M = ReadInt("Введите меньшее число: ");
    N = ReadInt("Введите большее число: ");
    CheckNum(M, N);
}

void CheckNum(int M, int N)
{

    if (M < N)
        PrintNumbers(M, N);
    else if (M > N)
    {
        System.Console.WriteLine("Числа поменяли местами из-за того, что M больше N");
        System.Console.WriteLine();
        int p = M;
        M = N;
        N = p;
        PrintNumbers(M, N);
    }
    else
    {
        System.Console.WriteLine("Вы ввели одинаковые числа, повторите попытку");
        System.Console.WriteLine();
        EnterNum();
    }
}
EnterNum();

