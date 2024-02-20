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

string[] ChangeMass(string[] str, int Len)       //Метод создания нового массива с элементами, длина которых менее "Len" символов
{
    int Count = 0;
    foreach (var n in str)
    {
        if (n.Length <= Len)
            Count++;
    }
    string[] newstr = new string[Count];
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
Console.WriteLine("Введите количество элементов массива, а затем задайте элементы массива");
int CountStr = int.Parse(Console.ReadLine()!);
str = CreateMass(CountStr);
Console.WriteLine($"Массив [{string.Join(", ", str)}]");
Console.Write($"Массив строковых значений менее 3 символов:");
Console.Write($" [{string.Join(", ", ChangeMass(str, 3))}]");