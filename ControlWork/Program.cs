// Задача. Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.

//1 вариант решения
/*
Console.Write("Введите количество элементов: ");
Console.WriteLine();
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = new string[size];
int length = 3;
int count = 0;

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= length)
    {
        newArray[count] = element;
        count++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();
*/

// 2 вариант решения

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateArray()
{
    string[] newArray = new string[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент:  ");
        newArray[i] = Convert.ToString(Console.ReadLine());
    }
   return newArray;
}
 
void ShowArray(string[] array)
{
    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}  "); 
}

string[] LengthOfArray(string[] array)
{
    string[] lenArray = new string[array.Length];
    int length = 3;
    for(int i = 0; i < size; i ++)
    {
        if (array[i].Length <= length)
        {
            lenArray[i] = array[i];
        }
    }
    return lenArray;
}

Console.WriteLine();
string[] myArray = CreateArray();
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine();
ShowArray(LengthOfArray(myArray));
Console.WriteLine();
