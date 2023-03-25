// ЗАДАЧА: Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.

string[] array = {"hello", "world", "123", "GB", ":-)"};
string[] newarray = new string[array.Length];
int count = 0;

void SecondArrayWithIF(string[] array, string[] newarray)
{
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newarray[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] newrray)
{
  
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write($"{newarray[i]} ");
    }
  
    Console.WriteLine();
}
SecondArrayWithIF(array,newarray);
PrintArray(newarray);