// Задача №4
// Напишите программу, которая на вход принимает натуральное число N,
// а на выход показывает его цифры через запятую.

Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 10)
{
    Console.WriteLine(N);
}
else
{
    while(N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if(N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}