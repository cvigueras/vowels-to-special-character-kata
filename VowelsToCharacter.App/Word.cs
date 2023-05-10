namespace VowelsToCharacter.App
{
    public class Word
    {
        public string Value { get; set; }
        public Dictionary<string, string> Replaces { get; }

        private Word(string word)
        {
            Value = word;
            Replaces = new Dictionary<string, string>
            {
                {"a","4"},
                {"e","3"},
                {"i","1"},
                {"o","0"},
                {"u","2"},
            };
        }

        public static Word? Create(string word)
        {
            return new Word(word);
        }

        public string ReplaceWord()
        {
            foreach (var character in Value)
            {
                var result = Replaces.FirstOrDefault(x => x.Key.Equals(character.ToString(),
                    StringComparison.OrdinalIgnoreCase));
                if (result.Value != null)
                {
                    Value = Value.Replace(result.Key, result.Value, StringComparison.OrdinalIgnoreCase);
                }
            }
            return Value;
        }
    }
}
