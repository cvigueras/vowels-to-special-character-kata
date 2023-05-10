namespace VowelsToCharacter.App
{
    public class VowelsHandler
    {
        private Word? _word;

        public string ReplaceWord(string word)
        {
            _word = Word.Create(word);
            return string.IsNullOrEmpty(_word!.Value) ? string.Empty : _word.ReplaceWord();
        }
    }
}