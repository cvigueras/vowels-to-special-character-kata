using FluentAssertions;
using VowelsToCharacter.App;

namespace VowelsToCharacter.Test
{
    public class VowelsHandlerShould
    {
        private VowelsHandler _vowelsHandler;

        [SetUp]
        public void SetUp()
        {
            _vowelsHandler = new VowelsHandler();
        }

        [TestCase("","")]
        [TestCase("A","4")]
        [TestCase("E","3")]
        [TestCase("I","1")]
        [TestCase("O","0")]
        [TestCase("U","2")]
        public void ReturnStringEmptyWhenLetterIsEmpty(string input, string expectedResult)
        {
            var result = _vowelsHandler.ReplaceWord(input);

            result.Should().Be(expectedResult);
        }
    }
}