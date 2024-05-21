// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {

            count++;
        }


    }
    return count;
}



int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);

int result = CountEvenNum(arr);
Console.WriteLine(result);




