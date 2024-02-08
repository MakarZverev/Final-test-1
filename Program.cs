// Массив для обработки
string[] inputStrings = new[]{"lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
    "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
    "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"};


// Функция для красивого вывода массива в консоль
// string[] strings - массив строк, который нужно вывести
void OutputStringsToConsole(string[] strings)
{
    string outputString = "[";
    foreach (string str in strings)
    {
        outputString += string.Format("\"{0}\", ", str);
    }
    outputString = outputString.Remove(outputString.Length - 2, 2);
    outputString += "]";
    Console.WriteLine(outputString);
}


void main()
{
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

    OutputStringsToConsole(shortStrings);
}


main();