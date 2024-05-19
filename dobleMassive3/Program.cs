// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

using System.Numerics;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];// создаем массив внутри функции rows-строки,columns-столбцы
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //используем цикл для прохождения по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// используем цикл фор для столбцов используем J так принято Начинаеться с 1,не с 0
        {
            matrix[i, j] = rnd.Next(min, max);//метод некст генерирует случайное число, заполняем массив случайными числами
        }                                    // далее будем использовать matrix.GetLength(0) Вместо rows и columns

    }
    return matrix;
}
void PrintMatrix(int[,] matrix) // метод 
{

    for (int i = 0; i < matrix.GetLength(0); i++) // просто цикл фор для строк
    {
        Console.Write("|"); //Пишем в начале для того чтоб выводимые на монитор перед цифрами выводилась скобка
        for (int j = 0; j < matrix.GetLength(1); j++)

        {
            Console.Write($"{matrix[i, j],4} ");// Последняя цифра в интерполяции это форматирование вывода цифр.
        }
        Console.WriteLine(" |");//закрывающая скобка 
    }
}
void PrintArray(double[] array) // метод 
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
double[] ArifmeticMeanRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];// sum * matrix[i,j]
        }
        array[i] = (double)sum / matrix.GetLength(1);// нахождение среднего арифметического. 
    }
    return array;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);// Вызываем метод(функцию)
PrintMatrix(array2d);// выводим результат функций на экран.
Console.WriteLine();

double[] result = ArifmeticMeanRows(array2d);
PrintArray(result);
