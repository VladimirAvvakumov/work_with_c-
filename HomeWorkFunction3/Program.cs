// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)


int[] array = { 1, 5, 3, 67, 9 };
Console.WriteLine(array);
int temp;



for (int i = 0; i < array.Length / 2; i++)
{

    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.Write("\nПеревернутый массив: ");
foreach (int e in array)
{
    Console.Write(e + " ");

}


