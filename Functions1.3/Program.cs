// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];// Создали массив-задали его размер
    Random rnd = new Random(); //метод создания случайных чисел

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);//метод некст генерирует случайное число, заполняем массив случайными числами
    }
    return array;
}
void PrintArray(int[] array) // метод 
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
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");//закрывающая скобка 
}
int ArrayToNumber(int[] array)// Метод создающий единое число из элементов массива.
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res = res * 10 + array[i];
    }
    return res;
}


Console.WriteLine("Задайте размер массива:");
int n =Convert.ToInt32(Console.ReadLine());
if (n > 8 || n < 1)
{
    return;
}

int[] arr = CreateArrayRndInt(n, 1, 10); // способ вызова функции напечатанной выше.
PrintArray(arr);// функция вызова чисел на экран
int result = ArrayToNumber(arr);
Console.WriteLine($"  => {result}");