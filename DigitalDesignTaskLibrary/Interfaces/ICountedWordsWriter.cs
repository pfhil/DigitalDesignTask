namespace DigitalDesignTaskLibrary.Interfaces
{
    public interface ICountedWordsWriter
    {
        Task WriteCountedWordsAsync(IDictionary<string, int> countedWords);
    }
}
