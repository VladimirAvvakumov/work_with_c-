//проверяет массив на четные элементы и выводит их на экран

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.WriteLine($"{e}");
    }
}
int[] array = { 1, 2, 3, 4, 5, 6 };
ZeroEvenElements(array);
PrintArray(array);