// Задача. Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] StringArray(int size = 5)
{
    string[] s = new string[size];
    for (int i = 0; i < size; i++)
    {
        s[i] = Console.ReadLine();
    }
    return s;
}

void Print(string[] s)
{
    for (int i = 0; i < s.Length; i++)
    {
        System.Console.Write($"{s[i],10}");
    }
}

string[] UpTo3Symbols(string[] stringArray)
{
    int outLen = 0;
   
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            outLen++;
        }
    }
    string[] newArray = new string[outLen];
    outLen = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[outLen] = stringArray[i];
            outLen++;
        }
    }
    return newArray;
}

string[] s = StringArray(5);
Print(s);
Console.WriteLine();
string[] newArray = UpTo3Symbols(s);
Print(newArray);

