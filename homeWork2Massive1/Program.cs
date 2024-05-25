// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1
// int[,] numbers = new int[,]
//    {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//    };


// int[] ArifmeticMeanRows(int[,] numbers)
// {
//     int[] array = new int[numbers.GetLength(0)];
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < numbers.GetLength(1); j++)
//         {
//             sum = sum + numbers[i, j];// sum + matrix[i,j]
//         }
//         array[i] = (int)sum;// без вывода на индекс элемента массива это не сработает.
//     }
//     return array;
// }
// void ShowNumbers(int[] array)
// {
//     foreach (int e in array)
//     {
//          Console.Write($"{array} ");
//     }
//     Console.WriteLine();
// }


// int[] result = ArifmeticMeanRows();
// ShowNumbers(result);

int[] numbers = { 6, 10, 17, 2 };
int minindex = numbers[0];
int imin = 0;

for (int i = 0; i < numbers.Length; i++)
{
    while (numbers[i] < minindex)
    {
        minindex =numbers[i]  ;
        imin =  i ;
    }
}

Console.WriteLine(imin);