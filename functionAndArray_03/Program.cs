// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.
 

Console.Write("Введите размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArray(size);
PrintArray(arr);

int[] RandomArray(int length)
{
    int[] array = new int[length];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   

    int sumMinus = 0;                                    //создаем переменную для суммы отрицательных чисел 
    int sumPlus = 0;                                     //переменная для суммы положительных чисел
 
    for (int i = 0; i < array.Length; i++)               //так же данный цикл можно было сделать в 2 дополнительных методах
    {
         if (array[i] < 0)                               
        {
           sumMinus += array[i]; 
        }
        else
        {
            sumPlus += array[i];
        }
        
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма отрицательных чисел --> {sumMinus}");
    Console.WriteLine($"Сумма положительных чисел --> {sumPlus}");
}