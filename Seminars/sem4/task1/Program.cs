// ЗАДАНИЕ №1

// Напишите программу, которая принимает на вход число 
// и выдаыет количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 ->

// Решение:

int DigitsCounter(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num /= 10;
        counter++;
    }
    return counter;
}
 System.Console.WriteLine("Input number: ");
 int num = Convert.ToInt32(Console.ReadLine());

 System.Console.WriteLine(DigitsCounter(num));