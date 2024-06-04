//Задача на реверс массива с помощью функции. 




int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
int temp;

foreach (int number in numbers)
{

    Console.Write(number + " ");
}
for (int i = 0; i < numbers.Length / 2; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}
Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");

}






