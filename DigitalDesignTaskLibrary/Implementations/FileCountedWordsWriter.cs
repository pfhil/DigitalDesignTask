using DigitalDesignTaskLibrary.Interfaces;

namespace DigitalDesignTaskLibrary.Implementations
{
    public class FileCountedWordsWriter : ICountedWordsWriter
    {
        private readonly StreamWriter _writer;

        public FileCountedWordsWriter(StreamWriter writer)
        {
            _writer = writer;
        }

        public async Task WriteCountedWordsAsync(IDictionary<string, int> countedWords)
        {
            foreach (var word in countedWords)
            {
                await _writer.WriteLineAsync($"{word.Key} - {word.Value}");
            }
        }
    }
}
