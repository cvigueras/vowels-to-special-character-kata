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
            //Given - Assert
            var vowelsHandler = new VowelsHandler();

            //When - Arrange
            var result = vowelsHandler.ReplaceWord(string.Empty);

            //Then - Act
            result.Should().BeEmpty();
        }
    }

    public class VowelsHandler
    {
        public VowelsHandler()
        {

        }

        public string ReplaceWord(string word)
        {
            throw new NotImplementedException();
        }
    }
}