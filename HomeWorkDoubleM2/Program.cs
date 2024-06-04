// Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены табуляцией.

// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4




int[,] array = new int[,] {
     {1, 2, 3, 4},
     {5, 6, 7, 8},
     {9, 10, 11, 12}
 }; 


void Printnumbers(int[,] array) // метод 
{

    for (int i = 0; i < array.GetLength(0); i++) 
    {
        Console.Write("|"); 
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine(" |");
    }

}
int[,] SwarpItems1(int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;
    for (int col = 0; col < array.GetLength(1); col++)
    {
        int temp = array[0, col];
        array[0, col] = array[lastRowIndex, col];
        array[lastRowIndex, col] = temp;
    }
    return array;

}


//int[,] numbers1 = CreatenumbersRndInt(3, 4, 1, 10);
//Printnumbers(result);// выводим результат функций на экран.
//Console.WriteLine();
int[,] result = SwarpItems1(array);
Printnumbers(result);








//  int numRows = array.GetLength(0);
//         int numCols = array.GetLength(1);

//         if (x < 1 || x > numRows)
//         {
//             Console.WriteLine("позиция по рядам выходит за пределы массива");
//             return -1;
//         }
//         if (y < 1 || y > numCols)
//         {
//             Console.WriteLine("позиция по колонкам выходит за пределы массива");
//             return -1;
//         }

//         return array[x - 1, y - 1];






