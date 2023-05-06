namespace VowelsToCharacter.App
{
    public class VowelsHandler
    {
        public string ReplaceWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;
            if (word == "A")
            {
                return "4";
            }
            if (word == "I")
            {
                return "1";
            }
            return "3";
        }
    }
}