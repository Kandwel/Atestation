//Задача 3: 
//Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.

int lenght = 10, i = 0;
int[] n = new int[lenght];

Random rand = new Random();

string reading;
GenerateArray();

void GenerateArray()
{
    i = 0;
    System.Console.Write("Массив чисел: ");
    for (i = 0; i < lenght; i++)
    {
        if (i != lenght - 1)
        {
            n[i] = rand.Next(1,50);
            System.Console.Write($" {n[i]},");
        }
        else
        {
            n[i] = rand.Next(1,50);
            System.Console.Write($" {n[i]}");
        }
    }

    Proverka();
}

void Proverka()
{
    Console.WriteLine();
    System.Console.Write("Вас устраивает массив? (Y/N) ");
    reading = Console.ReadLine();
    Console.WriteLine();
    if (reading != null)
    {
        if (reading == "Y" || reading == "y")
        {
            PrintNumbers(lenght);
        }
        else if (reading == "n" || reading == "N")
        {
            GenerateArray();
        }
        else
            Proverka();
    }
}

void PrintNumbers(int len)
{
    if (len == lenght)
        len--;

    if (len < 0) return;
    System.Console.Write(n[len] + " ");
    PrintNumbers(len - 1);
}