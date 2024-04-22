// Напишите программу, которая принимает на вход 
// трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256  => 26
// a = 891  => 81

Console.WriteLine("введите трехзначное число положительное");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int FirstDigit = num / 100; // 256 / 100 = 2.56 = 2
    int thirdDigit = num % 10; //  256

    int result = FirstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("некорекктный ввод");
}
