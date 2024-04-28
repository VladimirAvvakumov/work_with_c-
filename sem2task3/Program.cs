// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли первое число кратным второму.
// Если первое число не кратно второму, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int rem = num1 % num2;

if (rem == 0)
{
    System.Console.WriteLine("число кратное первому");
}
else
{

    System.Console.WriteLine("число некратное " + rem);
}
