using DigitalDesignTaskLibrary;
using DigitalDesignTaskLibrary.Implementations;

var fileSearcher = new FileSearcher(
    Console.ReadLine,
    Console.WriteLine
    );

var inputFilePath = fileSearcher.GetPathToExistFile("Укажите путь к текстовому файлу для чтения: ");
var outputFilePath = fileSearcher.GetPathToExistFile("Укажите путь к текстовому файлу для записи результата (Файл будет перезаписан): ");

using var reader = new StreamReader(inputFilePath);
using var writer = new StreamWriter(outputFilePath);

var fileWordsReader = new FileWordsReader(reader);
var wordsCounter = new WordsCounter(fileWordsReader);
var fileCountedWordsWriter = new FileCountedWordsWriter(writer);

await fileCountedWordsWriter.WriteCountedWordsAsync(wordsCounter.CountWords());