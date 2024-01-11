/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.Clear();

string[] EnteringArray(int size)
{
    string[] arr = new string[size];

    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < size; i++)
    {
        Console.Write("{0}>", i + 1);
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("\nМассив: ");
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int SearchingSizeNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count++;
    }
    return count;
}

string[] ArraySorting(string[] arr, int size)
{
    string[] result = new string[size];
    for (int i = 0, count = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    }
    return result;
}

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

string[] userArray = EnteringArray(size);
PrintArray(userArray);

int newSize = SearchingSizeNewArray(userArray);
string[] result = ArraySorting(userArray, newSize);
PrintArray(result);