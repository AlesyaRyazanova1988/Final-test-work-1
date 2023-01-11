/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


string[] stringArray = new string [] {"Hello", "2", "world", ":-)"};
PrintArray (stringArray);
Console.WriteLine();
string[] stringArray2 = new string [stringArray.Length];

int j=0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
        {
        stringArray2[j] = stringArray[i];
        j++;
        }
    
}
PrintArray (stringArray2);

void PrintArray(string[] array)
    {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    }










  










  
