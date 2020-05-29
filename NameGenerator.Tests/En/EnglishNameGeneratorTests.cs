using NameGenerator.En;
using Xunit;

namespace NameGenerator.Tests.En
{
    public class EnglishNameGeneratorTests : SpecificNameGeneratorTestsBase
    {
        private readonly IRandomNameGenerator _randomNameGenerator;

        public EnglishNameGeneratorTests() : base(new EnglishNameGenerator(), MaleNames.Default, FemaleNames.Default, LastNames.Default)
        {
            _randomNameGenerator = new EnglishNameGenerator();
        }

        [Theory]
        [InlineData(1000)]
        public void ShouldReturnAFullNameWithTwoWords(int iterations)
        {
            while(iterations-- > 0)
            {
                var name = _randomNameGenerator.GetFullName(50);
                Assert.Equal(2, name.Split(' ').Length);
            }
        }
    }
}