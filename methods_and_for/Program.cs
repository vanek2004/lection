Console.WriteLine("Задача №1");
string text = "я очень красивый мальчик" + " и еще очень умный";  

//возвращаемое значение
string AnotherText(string text, char oldValue, char newValue)
{
string result = String.Empty;    //создаем строку с пустым значением
int length = text.Length;        //находим длинну текста    
for (int i = 0; i < length; i++) 
{
    if (text[i] == oldValue)                 //если определенный элемент текста == oldValue, 
    {                                        //тогда
        result = result + $"{newValue}";     //присваиваем ему новый символ  
    }
    else
    {
        result = result + $"{text[i]}";      //иначе оставляем все как есть 
    }
}
 return result;                              //возвращаем result
}
 string newText = AnotherText(text, ' ', '|');     //создаем стринговою перерменную и помещаем туда наш text и указываем 
 Console.WriteLine($"{newText}");                  // oldValue and newValue                       
 newText = AnotherText(newText, 'а', 'А');               //к итоговому варианту добавляем дополнительные изменения
 Console.WriteLine(newText);
// 
// 
// 
// 
Console.WriteLine();
Console.WriteLine("Задача №2");

int[] array = {1, 3, 5, 3, 8, 9, 1, 2};
void PrintArray(int[] arr)
{
    int count = arr.Length;                          //задаем переменной размер массива
    for (int i = 0; i < count; i++) 
    {
        Console.WriteLine($"{arr[i]} ");             //вывод массива  
    }
    Console.WriteLine();
}



void SortArray(int[] arr)
{
for (int i = 0; i < arr.Length ; i++)                           //
{
    int minPosition = i;                                        //задаем позицию минимального числа
    for (int j = i + 1; j < arr.Length; j++)                    // цикл для сравнивания(j = i + 1)
    {
        if (arr[j] < arr[minPosition]) minPosition = j;         //если элемент меньше следующего, то даем позиции минимального элемента 
    }                                                           //то же значение

    int temp = arr[i];                                          //
    arr[i] = arr[minPosition];                                  // смена мест после проверки 
    arr[minPosition] = temp;                                    //
    Console.WriteLine($"{arr[i]}");                             // 
}
}
PrintArray(array);                                              //вывод массива
SortArray(array);                                               //вывод упорядоченного массива