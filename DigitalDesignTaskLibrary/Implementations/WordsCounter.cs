using DigitalDesignTaskLibrary.Interfaces;

namespace DigitalDesignTaskLibrary.Implementations
{
    public class WordsCounter : IWordsCounter
    {
        private readonly IWordsReader _wordsReader;

        public WordsCounter(IWordsReader wordsReader)
        {
            _wordsReader = wordsReader;
        }

        public Dictionary<string, int> CountWords()
        {
            var countedWords = new Dictionary<string, int>();
            foreach (var word in _wordsReader.GetWords())
            {
                if (countedWords.ContainsKey(word))
                {
                    countedWords[word]++;
                }
                else
                {
                    countedWords.Add(word, 1);
                }
            }

            return countedWords;
        }
    }
}
