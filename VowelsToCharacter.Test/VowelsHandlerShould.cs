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
        [TestCase("a", "4")]
        [TestCase("e", "3")]
        [TestCase("i", "1")]
        [TestCase("o", "0")]
        [TestCase("u", "2")]
        public void ReturnReplacedLetterWhenIsOnlyOneLetter(string input, string expectedResult)
        {
            var result = _vowelsHandler.ReplaceWord(input);

            result.Should().Be(expectedResult);
        }

        [Test]
        public void Return4b02tWhenWordIsAbout()
        {
            var result = _vowelsHandler.ReplaceWord("about");

            result.Should().Be("4b02t");
        }

        [Test]
        public void ReturnM0rn1ngWhenWordIsMorningWithUpperCase()
        {
            var result = _vowelsHandler.ReplaceWord("MORNING");

            result.Should().Be("M0RN1NG");
        }
    }
}