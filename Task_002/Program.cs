
int M, N;

int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return Akkerman(M - 1, 1);
    else return Akkerman(M - 1, Akkerman(M, N -1));
}

void EnterNum()
{
    M = ReadInt("Введите число 2: ");
    N = ReadInt("Введите число 3: ");
    int funAkk = Akkerman (M, N);
    System.Console.WriteLine();
    System.Console.WriteLine($"Функция Аккермана: {funAkk}");
}

EnterNum();
