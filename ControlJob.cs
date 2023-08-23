// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("Enter an array of 5 elements: ");

string[] GetArray(int size) //array creation method
{
    string[] arrayString = new string[size];
    for (int i = 0; i < size; i++)
    {
        string element = Convert.ToString(Console.ReadLine());
        arrayString[i] = element;
    }
    return arrayString;
}

void PrintArray(string[] arrayString) //array print method
{
    for (int i = 0; i < arrayString.Length; i++)
    Console.Write(arrayString[i] + "\t");
}

string[] ChangeArray(string[] stringArray) //search method and array element by task condition
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            count++;
    }
    string[] result = new string[count];
    int newElem = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[newElem] = stringArray[i];
            newElem++;
        }
    }
    return result;
}

string[] arrSymbol = GetArray(5);
PrintArray(arrSymbol);
Console.WriteLine();
PrintArray(ChangeArray(arrSymbol));