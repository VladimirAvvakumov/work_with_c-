// Считать строку с консоли, содержащую латинские
// буквы. Вывести на экран согласные буквы этой
// строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void CheckPrintConsonats(string txt, int index)
{
string vowels = "aeiouy";
if (char.IsLetter(txt[index]) && !vowels.Contains(txt[index])) //Проверяем массив на буква ли это isLetter
{
Console.Write($"{txt[index]}");
}
}

void PrintConsonants(string txt, int index = 0)
{
if (index == txt.Length)
{
return;
}
CheckPrintConsonats(txt, index);
PrintConsonants(txt, index + 1);
}

Console.WriteLine("введите строку содержащую латинские буквы: ");
string text = Console.ReadLine();
Console.WriteLine();
PrintConsonants(text);