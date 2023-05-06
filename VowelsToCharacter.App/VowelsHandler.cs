namespace VowelsToCharacter.App
{
    public class VowelsHandler
    {
        public string ReplaceWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;
            return Replaceword(word);
        }

        private static string Replaceword(string word)
        {
            if (word == "A")
            {
                return "4";
            }
            if (word == "I")
            {
                return "1";
            }
            if (word == "O")
            {
                return "0";
            }
            return "3";
        }
    }
}