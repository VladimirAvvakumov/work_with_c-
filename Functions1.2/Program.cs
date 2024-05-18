// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

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
int FindNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            count++;
        }
    }
    return count;
}



int[] arr = CreateArrayRndInt(40, 1, 100); // способ вызова функции напечатанной выше.
PrintArray(arr);// функция вызова чисел на экран
int result = FindNumbers(arr);
Console.Write($"=> {result} "); 
