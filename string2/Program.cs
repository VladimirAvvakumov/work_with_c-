// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]




char[] StringToCharArray( string s)// чар это символьный тип функция. переменная S / Стринг тот же инт.толко для символьных элементов.
{
char[] strArray = new char[s.Length];//Создаем массив стр,эррэй тип чар = выделяем место в памяти ньюЧар[]
for (int i = 0; i < s.Length; i++)
{
strArray[i] = s[i];
}
return strArray;
}

void PrintArray(char[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1)
Console.Write($"{array[i]}, ");
else
Console.Write($"{array[i]}");
}
Console.Write("]");
}
Console.WriteLine("введите строку");// Запрос на ввод. При запуске программы пользователь видит строку
string str = Console.ReadLine ();
char [] resArray = StringToCharArray (str);

PrintArray (resArray);