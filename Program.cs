using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст, завершающийся точкой:");
        string input = Console.ReadLine();

        // Убираем точку в конце для удобства обработки
        if (input.EndsWith("."))
        {
            input = input.TrimEnd('.');
        }

        char[] delimiters = { ' ', ',', '-' };
        string[] words = new string[input.Length]; // Массив для хранения слов
        int wordCount = 0;
        string currentWord = "";

        // Проходим по каждому символу, формируя слова
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            // Если текущий символ - разделитель
            if (Array.Exists(delimiters, element => element == currentChar))
            {
                if (currentWord.Length > 0)
                {
                    words[wordCount++] = currentWord; // Сохраняем слово
                    currentWord = ""; // Сбрасываем текущее слово
                }
            }
            else
            {
                currentWord += currentChar; // Собираем текущее слово
            }
        }

        // Добавляем последнее слово, если оно есть
        if (currentWord.Length > 0)
        {
            words[wordCount++] = currentWord;
        }

        // Формируем новую строку с переставленными словами
        string result = "";
        for (int i = wordCount - 1; i >= 0; i--)
        {
            result += words[i];
            if (i > 0)
            {
                result += " "; // Добавляем пробел между словами
            }
        }

        Console.WriteLine("Результат: " + result);
    }
}