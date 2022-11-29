
string[] CreateArrayOfString()
{
    Console.WriteLine("Введите количество строк в массиве");
    int count = int.Parse(Console.ReadLine()!);
    string[] userArrayOfStrings = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите строку {i + 1}");
        userArrayOfStrings[i] = Console.ReadLine();
    }
    return userArrayOfStrings;
}

void PrintArray(string[] col)
{
    Console.Write("[");
    Console.Write(String.Join(" ,", col));
    Console.WriteLine("]");
}

string[] CreateSortedArray(string[] arrayOfStrings)
{
    int count = 0;
    string stringOfIndices = String.Empty;
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length<=3)
        {
            stringOfIndices += i;
            count++;
        }
    }
    string[] sortedArrayOfString = new string[count];
    int j;
    for (int i = 0; i < count; i++)
    {
        j = (int)Char.GetNumericValue(stringOfIndices[i]);
        sortedArrayOfString[i]=arrayOfStrings[j];
    }
    return sortedArrayOfString;
}


Console.WriteLine("Программа, которая из имеющегося массива строк, формирует новый массив из строк,");
Console.WriteLine("длина которых меньше, либо равна 3 символам");
string[] userArrayOfStrings = CreateArrayOfString();
Console.WriteLine("Вы ввели массив:");
PrintArray(userArrayOfStrings);
System.Console.WriteLine("В результате получаем массив:");
PrintArray(CreateSortedArray(userArrayOfStrings));