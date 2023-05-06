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

        [Test]
        public void ReturnNumber4WhenLetterA()
        {
            var vowelsHandler = new VowelsHandler();

            var result = vowelsHandler.ReplaceWord("A");

            result.Should().Be("4");
        }

        [Test]
        public void ReturnNumber3WhenLetterE()
        {
            var vowelsHandler = new VowelsHandler();

            var result = vowelsHandler.ReplaceWord("E");

            result.Should().Be("3");
        }
    }
}