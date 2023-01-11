Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");

string[] FirstArray = BaseArray();
string[] result = new string[FirstArray.Length];

Console.Write($"{string.Join(" ", FirstArray)} -> ");

Less3Array(FirstArray, result);
WriteArray(result);

void Less3Array(string[] FirstArray, string[] result)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            result[count] = FirstArray[i];
            count++;
        }
    }
}

void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] BaseArray()
{
    Console.Write("Введите значения массива через пробел: ");
    return Console.ReadLine().Split(" ");
}
Console.WriteLine("Хорошего дня!");
