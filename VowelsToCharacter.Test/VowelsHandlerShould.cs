using FluentAssertions;
using VowelsToCharacter.App;

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
}