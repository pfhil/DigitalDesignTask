using DigitalDesignTaskLibrary.Interfaces;

namespace DigitalDesignTaskLibrary.Implementations
{
    public class FileWordsReader : IWordsReader
    {
        private readonly StreamReader _reader;

        public FileWordsReader(StreamReader reader)
        {
            _reader = reader;
        }

        public IEnumerable<string> GetWords()
        {
            while (true)
            {
                var str = _reader.ReadWord();
                if (!string.IsNullOrEmpty(str))
                {
                    yield return str;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
