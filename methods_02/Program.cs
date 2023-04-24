// // Напишите программу которая на вход принимает число А и выдает сумму чисел от 1 до А.

// Console.WriteLine("Введите число А --> ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// int sumNumber = SumNumber(numberA);
// Console.WriteLine(sumNumber);

// int SumNumber(int numA)
// {
//     int sum = 0;                                    //обязательно изначально создаем переменную для складывания чисел
//     for (int i = 0; i <= numA; i++)
//     {
//         checked                                     //оператор проверки переполнения 
//         {
//             sum += i; // sum = sum + 1;
//         }
        
//     }
//     return sum;                                     // return пишем вне цикла for
// }
// // 










// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// Console.Write("Введите число --> ");
// int number = Convert.ToInt32(Console.ReadLine());

// int length = Length(number);
// Console.WriteLine(length);

// int Length(int num)
// {
//     int count = 0;
//     for (int i = 0; i <= num + 1; i++)
//     {
//         num /= 10;                             //при делении числа на 10, часть числа переносится за запятую.
//         count++;                               // переменная для счетчика
//     }
//     return count;
// }
      








// // Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

// Console.Write("Введите число --> ");
// int number = Convert.ToInt32(Console.ReadLine());

// int product = Product(number);
// Console.WriteLine(product);

// int Product(int num)
// {
//     int count = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         count *= i;
//     }
//     return count;
// }







//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.



Console.Write("Введите длину массива --> ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArray(lengthArray); 
PrintArray(arr);

int[] RandomArray(int size)
{
    int[] array = new int [size];                   //создаем массив с размером lengthArray в методе 
    var random = new Random();                      // наименование рандомного элемента 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);               // даем каждому значению i случайное число от 0 до 1 с помощью вызова random
    }
return array;                                       // возвращаем массив
}
void PrintArray(int[] array)                        // метод вывода массива
{
   for (int i = 0; i < array.Length; i++)
   {
    Console.Write($"{array[i]} ");
   }
}