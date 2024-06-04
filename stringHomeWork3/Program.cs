
//Задайте произвольную строку. Выясните, является ли она палиндромом

// Входная строка для проверки 
string input = "шалаш";
// Вызов метода для проверки, является ли строка палиндромом
bool isPalindrome = IsPalindrome(input);
{
    // Вывод результата
    Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
// Метод для проверки, является ли строка палиндромом 
bool IsPalindrome(string str)
{
    // Нормализация строки путем удаления не буквенно-цифровых символов и приведения к нижнему регистру 
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    // Сравнение строки с ее перевернутым вариантом 
    return normalized.SequenceEqual(normalized.Reverse());
}
