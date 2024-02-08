// Массив для обработки
string[] inputStrings = new[]{"lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
    "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
    "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"};


// Считаем количество коротких строк
int outputArrayLength = 0;
foreach (string inputString in inputStrings)
{
    if (inputString.Length <= 3)
    {
        outputArrayLength++;
    }
}
// Создаем массив для коротких строк
string[] shortStrings = new string[outputArrayLength];

// Добавляем короткие строки в массив коротких строк
int counter = 0;
foreach (string inputString in inputStrings)
{
    if (inputString.Length <= 3)
    {
        shortStrings[counter++] = inputString;
    }
}

// Выводим массив коротких строк в консоль
foreach (string shortString in shortStrings)
{
    Console.WriteLine(shortString);
}

