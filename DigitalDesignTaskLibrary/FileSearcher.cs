namespace DigitalDesignTaskLibrary
{
    public class FileSearcher
    {
        private Func<string> userAnswer;

        private Action<string> userNotify;

        public FileSearcher(Func<string> userAnswer, Action<string> userNotify)
        {
            this.userAnswer = userAnswer;
            this.userNotify = userNotify;
        }

        public string GetPathToExistFile(string userNotification)
        {
            while (true)
            {
                userNotify.Invoke(userNotification);
                var path = userAnswer();

                if (File.Exists(path))
                {
                    return path;
                }

                userNotify.Invoke("Файл не был найден");
            }
        }
    }
}
