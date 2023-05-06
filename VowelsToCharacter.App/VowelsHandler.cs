namespace VowelsToCharacter.App
{
    public class VowelsHandler
    {
        private Word _word;

        public string ReplaceWord(string word)
        {
            _word = Word.Create(word);
            if (string.IsNullOrEmpty(_word.Value)) return string.Empty;
            return Replaceword(_word);
        }

        private static string Replaceword(Word word)
        {
            foreach (var character in word.Value)
            {
                var result = word.Replaces.FirstOrDefault(x => x.Key == character.ToString());
                if (result.Value != null)
                {
                    word.Value = word.Value.Replace(result.Key, result.Value).ToString();
                }
            }
            return word.Value;
        }
    }
}