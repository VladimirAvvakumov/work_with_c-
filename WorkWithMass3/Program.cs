// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Начальные условия:

// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Выводится: 5.15



double[] numbers = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
double FindMax = numbers[0];
double FindMin = numbers[0];


for (int i = 0; i < numbers.Length; i++)
{
    while (FindMax < numbers[i])
    {
        FindMax = numbers[i];

    }
}
for (int i = 0; i < numbers.Length; i++)
{
    while (FindMin > numbers[i])
    {
        FindMin = numbers[i];

    }
}
double result = FindMax - FindMin;
Console.WriteLine(result);

