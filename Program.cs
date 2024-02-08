// Массив для обработки
string[] inputStrings = new[]{"lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
    "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
    "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"};


// Функция выбора режима ввода массива
bool selectManualInput ()
{
    Console.WriteLine("Использовать ручной ввод массива строк?\nВведите Y для подтверждения.");
    return (Console.ReadLine().ToUpper() == "Y");
}


// Функция ввода из консоли массива для обработки
string[] stringsInput ()
{
    Console.WriteLine("Укажите количество слов в массиве");
    int arrayLength = Int32.Parse(Console.ReadLine());
    string[] strings = new string[arrayLength];
    Console.WriteLine("Введите слова:");
    for (int i = 0; i < strings.Length; i++)
    {
        strings[i] = Console.ReadLine();
    }
    return strings;
}


// Функция для красивого вывода массива в консоль
// string[] strings - массив строк, который нужно вывести
void OutputStringsToConsole (string[] strings)
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


void main ()
{
    // Предлагаем пользователю ввести массив вручную вместо предустановленного.
    if (selectManualInput())
    {
        inputStrings = stringsInput();
    }

    Console.WriteLine("Обрабатываемый массив:");
    OutputStringsToConsole(inputStrings);

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
    Console.WriteLine("Строки длинной <= 3 символам:");
    OutputStringsToConsole(shortStrings);
}


main();