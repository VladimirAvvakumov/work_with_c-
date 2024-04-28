// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
// 15



Console.WriteLine("Введите трехзначное число"); // 487

int num = Convert.ToInt32(Console.ReadLine());


if (num >= 100 && num <= 999)
{
    int secondDigit = num / 10 % 10; // 487 / 10 = 48 % 10 = 8
    int lastDigit = num % 10;  // 487 % 10 = 7
    int result = secondDigit;
    int count = 1;


    while (count < lastDigit)
    {
        result = result * secondDigit; // 8 * 8
        count++;
    }

Console.WriteLine(result); 
}
else
{
    System.Console.WriteLine("ошибка ввода");
}
