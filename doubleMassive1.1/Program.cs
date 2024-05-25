//Создать двумерный массив размером 3.5 и вывести его на экран.




int[,] CreateNumbers(int rows, int colums)
{
    int[,] numbers = new int[rows, colums];// Создаем массив= выделяем в памяти место .
    Random rnd = new Random();


    for (int i = 0; i < numbers.GetLength(0); i++)// используем свойство GetLangth(0). цифра ноль требует пробежаться по строкам.
    {
        for (int j = 0; j < numbers.GetLength(1); j++) // цифра один означает что цикл идет по столбцам , Вертикально.
        {


            numbers[i, j] = rnd.Next(1, 11);
        }
    }
    return numbers;
}
void ShowNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)// используем свойство GetLangth(0). цифра ноль требует пробежаться по строкам.
    {
        for (int j = 0; j < numbers.GetLength(1); j++) // цифра один означает что цикл идет по столбцам , Вертикально.
        {
            Console.Write($"{numbers[i, j]} ");// интерполяция строк.Пробел после квадратных скобок для пробела при выводе цифр


        }
        Console.WriteLine();
    }
}
int[,] num = CreateNumbers(4, 5);
ShowNumbers(num);