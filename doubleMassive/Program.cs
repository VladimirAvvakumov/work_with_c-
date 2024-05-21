// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 
// 2 9 5 4
// =>
// столбцы    1  2  3   4

// [0]        4  3  16  3
// [1]        4  3  4   1
// [2]        4  9  25  4



using System.Numerics;

int[,] CreateMatrixRndInt(int rows, int columns ,  int min, int max)
{
    int[,] matrix = new int[rows,columns];// создаем массив внутри функции rows-строки,columns-столбцы
    Random rnd = new Random(); 

    for (int i = 0; i < matrix.GetLength(0); i++) //используем цикл для прохождения по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// используем цикл фор для столбцов используем J так принято Начинаеться с 1,не с 0
        {
            matrix[i,j] = rnd.Next(min, max);//метод некст генерирует случайное число, заполняем массив случайными числами
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
            Console.Write($"{matrix[i, j], 4} ");// Последняя цифра в интерполяции это форматирование вывода цифр.
        }
        Console.WriteLine(" |");//закрывающая скобка 
    }

}
void ElemEvenindexesToSquare(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)//  сие означает, что идем по четным индексам строк
    {
        for (int j = 0; j < matrix.GetLength(1);j+=2)// это четные индексы столбцов
        {
            //if (i % 2 == 0 && j % 2 ==0) закоментировали ветвление иф так как в цикле фор научились идти по четным индексам и нечетным.
            //{
                matrix[i,j] *=matrix[i,j];// означет на само себя умножить matrix[i,j] * matrix[i,j]
            //}
        }
    }
}


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);// Вызываем метод(функцию)
PrintMatrix(array2d);// выводим результат функций на экран.
Console.WriteLine();
ElemEvenindexesToSquare(array2d);
PrintMatrix(array2d);