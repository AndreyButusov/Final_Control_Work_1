using System.Text;

Console.Clear();
Console.InputEncoding = Encoding.Unicode;

string[] CreateMass(int CountStr)       //Создание массива длиной, определенной пользователем
{
    string[] Array = new string[CountStr];
    for (int i = 0; i < CountStr; i++)
    {
        Array[i] = Console.ReadLine()!;
    }
    return Array;
}

int CountSmallString(string[] str, int Len)      //Счетчик количества коротких значений в массиве
{
    int Count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= Len)
            Count++;
    }
    return Count;
}

string[] ChangeMass(string[] str, int Len)       //Метод создания нового массива с элементами, длина которых менее "Len" символов
{
    string[] newstr = new string[CountSmallString(str, Len)];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= Len)
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
Console.Write($"Массив строковых значений менее 3 символов:");
Console.Write($" [{string.Join(", ", ChangeMass(str, 3))}]");