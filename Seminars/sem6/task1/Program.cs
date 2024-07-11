// Задание №1
// Задайте массив символов (тип char []). Создайте строку 
// из символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример:
// ['a', 'b', 'c', 'd'] => "abcd"

// Решение:

string CharsToStrings(char[] chars)
{
    string result = string.Empty; // объявили переменную result и присвоили ей значение "пусто"
    for(int i = 0; i < chars.Length; i++)
    {
        result += chars[i]; // проходим по элементам массива и каждый из них приписываем строке result
    }
    return result; // возвращаем метод
}

char [] chars = {'a', 'b', 'c', 'd', 'e', '@'}; // создали массив символов char
System.Console.WriteLine(CharsToStrings(chars));