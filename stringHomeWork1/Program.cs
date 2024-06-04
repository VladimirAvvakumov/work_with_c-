// Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива.




char[,] array = new char[,]
{
    {'H','e','l','l','o','W','o','r','l','d'},
    {'W','o','r','l','d','H','e','l','l','o'}
};
string Onestring(char[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)// проходим циклом по всему слову тут по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)//Проходим по столбцам
        {
            result = result + array[i, j];
        }

    }
    return result;
}

string arr = Onestring(array);
Console.WriteLine(arr);