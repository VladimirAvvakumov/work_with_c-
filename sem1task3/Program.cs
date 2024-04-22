// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 99 && num < 1000)
{

    int FirstDigit = num / 100;
    int LastDigit = num % 10;
    int sum = FirstDigit + LastDigit;

    Console.WriteLine($"сумма первой и последней цифры = {sum}");
}
else
{
    Console.WriteLine("неправильное число");
}