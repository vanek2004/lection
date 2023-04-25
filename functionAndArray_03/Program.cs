// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.
 

// Console.Write("Введите размер массива --> ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray(size);
// PrintArray(arr);

// int[] RandomArray(int length)
// {
//     int[] array = new int[length];
//     var random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(-9, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }   

//     int sumMinus = 0;                                    //создаем переменную для суммы отрицательных чисел 
//     int sumPlus = 0;                                     //переменная для суммы положительных чисел
 
//     for (int i = 0; i < array.Length; i++)               //так же данный цикл можно было сделать в 2 дополнительных методах
//     {
//          if (array[i] < 0)                               
//         {
//            sumMinus += array[i]; 
//         }
//         else
//         {
//             sumPlus += array[i];
//         }
        
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма отрицательных чисел --> {sumMinus}");
//     Console.WriteLine($"Сумма положительных чисел --> {sumPlus}");
// }








// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



// Console.Write("Введите размер массива --> ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size);
// PrintArray(array);
// Console.WriteLine();
// ReturnArray(array);

// int[] CreateArray(int length)
// {
//     int[] arr = new int[length];
//     var random = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(-9, 10);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// void ReturnArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
    
// }






// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.WriteLine("Введите размер массива и число которое вы хотели бы найти в массиве --> ");
Console.Write("Введите size --> ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите number --> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);


int[] CreateArray(int length)
{
    int[] arr = new int[length];
    var random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-9, 10);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

bool FindNumber(int[] arr,int num)                  // метод типа bool выводит true or false
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}
bool findNumber = FindNumber(array, number);
Console.WriteLine();
Console.WriteLine(findNumber ? "yes" : "no");         // задаем нашим true and false текст

