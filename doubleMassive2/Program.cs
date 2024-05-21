// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

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
int SumElementsToDiagonal(int[,] matrix)
{
    int sum = 0; //Закомитили потому что 

    // int minSize = matrix.GetLength(0);
    // if (matrix.GetLength(1) < minSize)
    // {
    //     minSize = matrix.GetLength(1);
    // }


    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
       sum = sum + matrix[i,i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);// Вызываем метод(функцию)
PrintMatrix(array2d);// выводим результат функций на экран
Console.WriteLine();
int result = SumElementsToDiagonal(array2d);
Console.WriteLine(result); 



