// Задание №2
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 


string CharsToStrings(char[] chars)
{
    string result = string.Empty; // объявили переменную result и присвоили ей значение "пусто"
    for(int i = 0; i < chars.Length; i++)
    {
        result += chars[i]; // проходим по элементам массива и каждый из них приписываем строке result
    }
    return result; // возвращаем метод
}   



char[] StringToChars(string str)
{
    char[] result = new char[str.Length]; // создали пустой массив
    for(int i = 0; i < str.Length; i++)
    {
        result [i] = str[i]; // каждому эл-ту [i] массива result присваимваем [i] значение строки  
    }
    return result; // вернем переписанный массив
}

void PrintArray(char[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write("'" + array[i] + "' "); // добавили к значению эл-та массива (') спереди и (') сзади + пробел(при выводе на консоль)
    }
    System.Console.WriteLine("");
}

PrintArray(StringToChars("abcdef"));