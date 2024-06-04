// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5





int[] numbers = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3, 87, 65 };
int count = 0;
int minRange = 10;
int maxRange = 90;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= minRange && numbers[i] <= maxRange)
    {
        count = count + 1;

    }

}
return (count);




