namespace VowelsToCharacter.App
{
    public class Word
    {
        public string Value { get; }
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
            };
        }

        public static Word Create(string word)
        {
            return new Word(word.ToUpper());
        }
    }
}
