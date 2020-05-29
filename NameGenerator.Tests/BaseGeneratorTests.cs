using Xunit;

namespace NameGenerator.Tests
{
    public class BaseGeneratorTests
    {
        private readonly IRandomNameGenerator _nameGenerator;
        private readonly SpecificRandomMocker _mockRandomGenerator;
        private readonly INameList _maleNamesForAssert;
        private readonly INameList _femaleNamesForAssert;

        public BaseGeneratorTests()
        {
            _maleNamesForAssert = new MockMaleNames();
            _femaleNamesForAssert = new MockFemaleNames();
            _mockRandomGenerator = new SpecificRandomMocker();
            _nameGenerator = new NameGeneratorBaseFixture(_mockRandomGenerator);
        }

        [Fact]
        public void ShouldReturnMaleForTheFirst50Percent()
        {
            for (var i = 0; i <= 0xFF; i++)
            {
                // Jcl: The default test generator uses a random byte (0-256) and normalizes it to 0..1 to get the probability
                _mockRandomGenerator.SetNextByte((byte)i);
                var name = _nameGenerator.GetFirstName(50);
                Assert.Contains(name, i < 128 ? _maleNamesForAssert.Names : _femaleNamesForAssert.Names);
            }
            
        }
    }
}