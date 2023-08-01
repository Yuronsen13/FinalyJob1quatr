// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = new string[4] {"HELLO", "2", "WORLD", ":)"};
string[] array2 = new string[array1.Length];

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(array1, array2);
PrintArray(array2);


// int m = 3;
// int size = 4;
// string[]array1 = new string[size];
// Console.WriteLine($"Введите количество {size} заданных слов через пробел");

// FillArray(array1);
// PrintArray(array1);
// Console.Clear();

// void FillArray(string[]array)
// {
//     for (int i=0; i<size; i++)
//     {
//         array[i]=Console.ReadLine();
//         i++;
//     }
// }

// void PrintArray(string[]array)
// {
//     int arrayLenght = array.Lenght
//     for (int i=0; i<array.Lenght; i++)
//     {
//         Console.WriteLine(array[i]+ " ");
//     }
// }



// void GetTwoSizeArray(string[]array)
// {
//     int count = 0;
//     for (int i = 0; i<size; i++)
//     {
//         if (array[i].Length <= m)
//         {
//             count++;
//         }
//     }
//     return count;
// }



//     if GetTwoSizeArray((array1)==0)
// {
//     Console.WriteLine($"Искомого элемента нет");
// }
//     else
// {
//     string[]array2 = TransferElements[array1];
//     PrintArray(array2);
// }



// string[]TransferElements(string[]array)
// {
//     string[]array2 = new string[GetTwoSizeArray(array1)];
//     for (int i = 0; int j = 0; i < size; i++)
//     {
//         if (array[i].Lenght <= m)
//         {
//             array2[i]=array1[i];
//             j++;
//         }
//     }
//     return array2;
// }
