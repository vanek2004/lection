string text = "я очень красивый мальчик" + " и еще очень умный";  

string AnotherText(string text, char oldValue, char newValue)
{
 string result = String.Empty;
int length = text.Length;
for (int i = 0; i < length; i++)
{
    if (text[i] == oldValue)
    {
        result = result + $"{newValue}";
    }
    else
    {
        result = result + $"{text[i]}";
    }
}
 return result;
}
 string newText = AnotherText(text, ' ', '|');
 Console.WriteLine($"{newText}");
