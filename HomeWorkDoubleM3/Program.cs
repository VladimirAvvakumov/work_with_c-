// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1




using System.Drawing;

int[,] CreatenumbersRndInt(int rows, int columns, int min, int max)
{
    int[,] numbers = new int[rows, columns];// создаем массив внутри функции rows-строки,columns-столбцы
    Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++) //используем цикл для прохождения по строкам
    {
        for (int j = 0; j < numbers.GetLength(1); j++)// используем цикл фор для столбцов используем J так принято Начинаеться с 1,не с 0
        {
            numbers[i, j] = rnd.Next(min, max);//метод некст генерирует случайное число, заполняем массив случайными числами
        }                                    // далее будем использовать matrix.GetLength(0) Вместо rows и columns

    }
    return numbers; // так как метод(функция) int значит есть возвращаемое значение
}
void Printnumbers(int[,] numbers) // метод 
{

    for (int i = 0; i < numbers.GetLength(0); i++) // просто цикл фор для строк
    {
        Console.Write("|"); //Пишем в начале для того чтоб выводимые на монитор перед цифрами выводилась скобка
        for (int j = 0; j < numbers.GetLength(1); j++)

        {
            Console.Write($"{numbers[i, j],4} ");// Последняя цифра в интерполяции это форматирование вывода цифр.
        }
        Console.WriteLine(" |");//закрывающая скобка 
    }

}
void PrintArray(int[] array) // метод 
{
    Console.Write("["); //Пишем в начале для того чтоб выводимые на монитор перед цифрами выводилась скобка
    for (int i = 0; i < array.Length; i++) // просто цикл фор 
    {
        if (i < array.Length - 1) // если ай меньше длинны массива - 1
        {
            Console.Write($"{array[i]}, "); // интерпаляция выводим элементы через запятую
        }
        else
        {
            Console.Write($"{array[i]}");// Console.Write($"{array[i]:F2}")заканчиваеться на ф2- это округление вывода чтоб сократить цифры 4.77777
        }

    }
    Console.Write("]");//закрывающая скобка 
}
int[] ArifmeticMeanRows(int[,] numbers)
{
    int[] array = new int[numbers.GetLength(0)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];// sum + matrix[i,j]
        }
        array[i] = (int)sum;// без вывода на индекс элемента массива это не сработает.
    }
    return array;
}
int FindminDigit(int[] array)
{
    
    int min = array[0];
    int imin = 0;

    for (int i = 1; i < array.Length ; i++)
    {
        while (array[i] < min)
        {
            min = array[i];
            imin = i;
        }

    }
    return imin;

}

int[,] array2d = CreatenumbersRndInt(4, 3, 1, 10);// Вызываем метод(функцию)
Printnumbers(array2d);// выводим результат функций на экран.
Console.WriteLine();

int[] result = ArifmeticMeanRows(array2d);
PrintArray(result);
int Findmin = FindminDigit(result);
Console.WriteLine(Findmin);