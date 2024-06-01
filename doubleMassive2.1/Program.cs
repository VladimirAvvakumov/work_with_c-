//назовем число интересным если его сумма цифр четная
//Создать двумерный массив заполнить его случайными элементами
//и вывести их на экран.


int[,] CreateNumbers(int rows, int colums)
{
    int[,] numbers = new int[rows, colums];// Создаем массив= выделяем в памяти место .
    Random rnd = new Random();


    for (int i = 0; i < numbers.GetLength(0); i++)// используем свойство GetLangth(0). цифра ноль требует пробежаться по строкам.
    {
        for (int j = 0; j < numbers.GetLength(1); j++) // цифра один означает что цикл идет по столбцам , Вертикально.
        {


            numbers[i, j] = rnd.Next(1, 1000);
        }
    }
    return numbers;
}
int[,] numbers = CreateNumbers(3, 4);
foreach (int e in numbers)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine($"{e} ");
    }
}
bool IsInteresting(bool value)
{
    bool sumOfDigits = GetSumOfDigits(value);
    if(sumOfDigits % 2 == 0)
    {
        return true;
    }
    // else  можно сократить потому что если не попадем в правду то елс выполниться на автомате
    // {
    return false;
    // }
}

int GetSumOfDigits(value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += sum + value % 10;
        value /= 10;
    }
    return sum;
}

