Console.Clear();

string[] CreateMass(int CountStr)       //Создание массива длиной, определенной пользователем
{
    string[] Array = new string[CountStr];
    for (int i = 0; i < CountStr; i++)
    {
        Array[i] = Console.ReadLine()!;
    }
    return Array;
}

int CountSmallString(string[] str)      //Счетчик количества коротких значений в массиве
{
    int Count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
            Count++;
    }
    return Count;
}

string[] ChangeMass(string[] str)       //Метод создания нового массива с элементами, длина которых менее 3 символов
{
    string[] newstr = new string[CountSmallString(str)];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            newstr[j] = str[i];
            j++;
        }
    }
    return newstr;
}

string[] str;
Console.WriteLine("Введите количество элементов массива а затем задайте массив");
int CountStr = int.Parse(Console.ReadLine()!);
str = CreateMass(CountStr);
Console.WriteLine($"Массив [{string.Join(", ", str)}]");
Console.Write("Массив коротких строковых значений:");
Console.Write($" [{string.Join(", ", ChangeMass(str))}]");