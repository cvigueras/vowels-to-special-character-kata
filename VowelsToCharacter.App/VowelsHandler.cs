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
            if (word.ToUpper() == "A")
            {
                return "4";
            }
            if (word.ToUpper() == "I")
            {
                return "1";
            }
            if (word.ToUpper() == "O")
            {
                return "0";
            }
            if (word.ToUpper() == "U")
            {
                return "2";
            }
            return "3";
        }
    }
}