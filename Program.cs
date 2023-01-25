//=========== Задача 1 ============
//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
//Первоначальный массив вводим с клавитуры или задаем на старте алгоритма. Не коллекции, только массивы.
//=========== Задача 1 ============



string [] CreateArray(int size)                       
{
    string [] array = new string[size];
    int i = 0;
    while (i < size)    
    {
        Console.WriteLine($"Введите любые {size} строк(и) через Enter: ");
        array[i] = Console.ReadLine();
        i++;        
    }
    return array;
}

void ShowArray(string [] array)
{
    Console.Write("[");
    foreach (var item in array) 
    {
        Console.Write($"{item} ");
    }       
}

Console.WriteLine("Давайте узнаем, сколько строк во введенном Вами массиве содержат 3 и менее символов!");
l1:Console.WriteLine("Сколько элементов Вы хотите видеть в массиве? Введите цифрой/числом: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0)
      {
        Console.WriteLine("Количество элементов не должно быть рано нулю! Введите значение еще раз: ");goto l1;        
      }

string [] arrayBase = CreateArray(size);
ShowArray(arrayBase);
Console.Write("] -> ");

//// Вообще, если делать выборку результатов ТОЛЬКО как в приведенном примере, можно обойтись таким вот костылем и будет работать! :)

// string [] LessThan3(string [] array, int size)        
// {                 
//     string [] array1 = new string[size];
//     int count = 0; 
//     string s = "0k0";                               
//     for (int i = 0; i < arrayBase.Length; i++)
//     { 
//         if(arrayBase[count].Length <= s.Length)
//         {
//             array1[i] = arrayBase[count]; 
//             count++; 
//         }                                                           
//     }    
    
//     return array1;    
// }

// string [] arraySorted = LessThan3(arrayBase, size);
//ShowArray(arraySorted);

int CountSymbols(string [] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }        
    }

    return counter;
}

string [] LessThan3SymbolsArray(string [] array)
{
    int arraySortedSize = CountSymbols(arrayBase);
    string [] arraySorted = new string[arraySortedSize];
    int i = 0;

    foreach (string item in arrayBase)
    {
        if (item.Length <= 3)
        {
            arraySorted[i] = item;
            i++;
        }        
    }
    
    return arraySorted;
}

string [] arraySorted = LessThan3SymbolsArray(arrayBase);
ShowArray(arraySorted);
Console.Write("]");