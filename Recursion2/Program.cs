// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    PrintNaturalNumbers(num -1);// функция вызывает сама себя(рекурсия)
    Console.Write($"{num} ");// если переставить на две строчки выше то выведеться в обратном порядке. 
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number);


// int Factorial(int n)
// {
// if(n == 1) return 1;
// return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5)); // 120


