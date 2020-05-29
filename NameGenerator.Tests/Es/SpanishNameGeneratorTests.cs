using NameGenerator.Es;
using Xunit;

namespace NameGenerator.Tests.Es
{
    public class SpanishNameGeneratorTests : SpecificNameGeneratorTestsBase
    {
        private readonly IRandomNameGenerator _randomNameGenerator;

        public SpanishNameGeneratorTests() : base(new SpanishNameGenerator(), MaleNames.Default, FemaleNames.Default, LastNames.Default )
        {
            _randomNameGenerator = new SpanishNameGenerator();
        }

        [Theory]
        [InlineData(1000)]
        public void ShouldReturnAFullNameWithTwoLastNames(int iterations)
        {
            while(iterations-- > 0)
            {
                var name = _randomNameGenerator.GetFullName(50);
                // At least 3, max 4 words (one first name which might be two words, and two last names)
                Assert.InRange(name.Split(' ').Length, 3, 4);
            }
        }
   }
}