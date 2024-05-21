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


using System.Globalization;

int[,] CreatenumbersRndInt(int rows, int columns ,  int min, int max)
{
    int[,] numbers = new int[rows,columns];// создаем массив внутри функции rows-строки,columns-столбцы
    Random rnd = new Random(); 

    for (int i = 0; i < numbers.GetLength(0); i++) //используем цикл для прохождения по строкам
    {
        for (int j = 0; j < numbers.GetLength(1); j++)// используем цикл фор для столбцов используем J так принято Начинаеться с 1,не с 0
        {
            numbers[i,j] = rnd.Next(min, max);//метод некст генерирует случайное число, заполняем массив случайными числами
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
            Console.Write($"{numbers[i, j], 4} ");// Последняя цифра в интерполяции это форматирование вывода цифр.
        }
        Console.WriteLine(" |");//закрывающая скобка 
    }

}
int SumStringNumbers(int[,] numbers)
{
    int sum;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = numbers[0,1];
        // int sum1 = numbers[1,0] + numbers[2,1] + numbers[3,2];
            
        return sum;
    }
    
}







int[,] num = CreatenumbersRndInt(4, 3, 1, 9);// Вызываем метод(функцию)
Printnumbers(num);// выводим результат функций на экран.
Console.WriteLine();
SumStringNumbers(num);
Console.WriteLine();