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






// Задача №33. Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// Console.WriteLine("Введите размер массива и число которое вы хотели бы найти в массиве --> ");
// Console.Write("Введите size --> ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите number --> ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size);
// PrintArray(array);


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

// bool FindNumber(int[] arr,int num)                  // метод типа bool выводит true or false
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num) return true;
//     }
//     return false;
// }
// bool findNumber = FindNumber(array, number);
// Console.WriteLine();
// Console.WriteLine(findNumber ? "yes" : "no");         // задаем нашим true and false текст







// Задача №35. Задайте одномерный массив из 123 случайных чиел.
// Найдите количество элементов массива, значения которых лежат в отрезке (10, 99)
// [10, 11, 12, 13, 14] --> 5

// Console.Write("- Введите размер массива --> ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size);
// PrintArray(array);
// int findQuantityNumbers = FindQuantityNumbers(array);
// Console.WriteLine();
// Console.WriteLine($"Колличество чисел в отрезке (10, 99) = {findQuantityNumbers}");

// int[] CreateArray(int length)
// {
//     int[] arr = new int[length];
//     var random = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(0, 124);
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

// int FindQuantityNumbers (int[] arr)
// { 
//     int quantity = 0;
   
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99) quantity++;
//     }
//     return quantity;
// }









// Задача №37. Надите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент и т.д.
// Результат записать в новом массиве.
// [1 2 3 4] --> 4 6

Console.Write("- Введите размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine();
int[] productPairsNumbers = ProductPairsNumbers(array);
PrintArray(productPairsNumbers);


int[] CreateArray(int length)
{
    int[] arr = new int[length];
    var random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 10);
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

int[] ProductPairsNumbers (int[] arr)
{ 
   
    int size = arr.Length / 2;                                    //делим на 2 для того что бы счетчик потом не вышел за половину
    if (arr.Length % 2 == 1) size += 1;
   
    int[] arrTwo = new int[size];                                 //создаем новый массив, который будем заполнять
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrTwo[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrTwo;
}