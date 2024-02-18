Console.Clear();

string[] CreateMass(int CountStr)
{
    string[] Array = new string[CountStr];
    for (int i = 0; i < CountStr; i++)
    {
        Array[i] = Console.ReadLine()!;
    }
    return Array;
}

string[] str;
Console.WriteLine("Введите количество элементов массива а затем задайте массив");
int CountStr = int.Parse(Console.ReadLine()!);
str = CreateMass(CountStr);
Console.Write($"Массив [{string.Join(", ", str)}]");