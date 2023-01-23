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
        Console.WriteLine("Количество строк не может быть рано нулю! Введите значение еще раз: ");goto l1;        
      }

string [] arrayBase = CreateArray(size);
ShowArray(arrayBase);
Console.Write("] -> ");

string [] LessThan3(string [] array, int size)        //не хочет, зараза, быть красиво написанные вверху =( потому что у нас нет точки вхождения метода Main, как я помню
                                                      // но поскольку нас этому еще не учили, хоть и показали, то и я не буду использовать
{                 
    string [] array1 = new string[size];
    int count = 0; 
    string s = "0k0";                               //Я подставила костыль) он работает, но только если вводим лишь цифры или лишь буквы или символы типа смайла
    for (int i = 0; i < arrayBase.Length; i++)
    { 
        if(arrayBase[count].Length <= s.Length)
        {
            array1[i] = arrayBase[count]; 
            count++; 
        }                                                           
    }    
    
    return array1;    
}

string [] arraySorted = LessThan3(arrayBase, size);
ShowArray(arraySorted);

// for (int i = 0; i < arrayBase.Length; i++)
// { 
//     if (arraySorted[i] != null)
//     {
//         ShowArray(arraySorted);          
//     }  
//     else 
//     {
//         Console.WriteLine("Я не шмогла...");   
//     }  
// }

