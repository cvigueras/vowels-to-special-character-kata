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
                {"A","4"},
                {"E","3"},
                {"I","1"},
                {"O","0"},
                {"U","2"},
                {"a","4"},
                {"e","3"},
                {"i","1"},
                {"o","0"},
                {"u","2"},
            };
        }

        public static Word Create(string word)
        {
            return new Word(word);
        }
    }
}
