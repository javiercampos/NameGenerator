using NameGenerator.Sv;
using Xunit;

namespace NameGenerator.Tests.Sv
{
    public class SwedishNameGeneratorTests : SpecificNameGeneratorTestsBase
    {
        private readonly IRandomNameGenerator _randomNameGenerator;

        public SwedishNameGeneratorTests() : base(new SwedishNameGenerator(), MaleNames.Default, FemaleNames.Default, LastNames.Default)
        {
            _randomNameGenerator = new SwedishNameGenerator();
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