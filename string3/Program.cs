// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str)
{
    string vowels = "aeyuio";
    int count = 0;
    for (int i = 0; i < str.Length; i++)// проходим циклом по всему слову
    {
        for (int j = 0; j < vowels.Length; j++) //этот цикл для прохода по всем гласным
        {
            if ( str[i] == vowels[j]) //Сравниваем все буквы слова со всеми гласными
            {
                count++; // Если гласная найдена счетчик плюс один
            }
        }
    }
    return count;
}
// string vowels = "aeyuio";
//     int count = 0;
// встроеный метод контейнс проверяет на правду лож.   
//         for (int i= 0; i < str.Length; i++) //этот цикл для прохода по всем гласным
//         {
//             if (vowels.Contains(str[i])) //Сравниваем все буквы слова со всеми гласными
//             {
//                 count++; // Если гласная найдена счетчик плюс один
//             }
//         }
    
//     return count;



Console.WriteLine("напишите слово");
string start = Console.ReadLine();
Console.Write($"В слове {CountVowels(start) } гласных");
