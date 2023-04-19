using System.Text;

namespace DigitalDesignTaskLibrary
{
    public static class StreamReaderExtension
    {
        public static string ReadWord(this StreamReader reader)
        {
            var str = new StringBuilder();
            while (true)
            {
                var intChr = reader.Read();
                if (intChr == -1)
                {
                    break;
                }

                var chr = (char)intChr;
                if (char.IsLetterOrDigit(chr) || chr == '\'')
                {
                    str.Append(char.ToLower(chr));
                }
                else if (str.Length != 0)
                {
                    if (str.ToString().All(chr => chr == '\''))
                    {
                        str.Clear();
                        continue;
                    }
                    break;
                }
            }

            if (str.ToString().All(chr => chr == '\''))
            {
                str.Clear();
            }

            return str.ToString();
        }
    }
}
