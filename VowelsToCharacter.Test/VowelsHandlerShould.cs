using FluentAssertions;

namespace VowelsToCharacter.Test
{
    public class VowelsHandlerShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ReturnStringEmptyWhenLetterIsEmpty()
        {
            var vowelsHandler = new VowelsHandler();

            var result = vowelsHandler.ReplaceWord(string.Empty);

            result.Should().BeEmpty();
        }
    }

    public class VowelsHandler
    {
        public string ReplaceWord(string word)
        {
            return string.Empty;
        }
    }
}