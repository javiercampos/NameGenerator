using Xunit;

namespace NameGenerator.Tests
{
    public abstract class SpecificNameGeneratorTestsBase
    {
        protected readonly IRandomNameGenerator RandomNameGenerator;
        protected readonly INameList MaleNamesCollection;
        protected readonly INameList FemaleNamesCollection;
        protected readonly INameList LastNamesCollection;

        protected SpecificNameGeneratorTestsBase(IRandomNameGenerator randomNameGenerator, INameList maleNames, INameList femaleNames, INameList lastNames)
        {
            RandomNameGenerator = randomNameGenerator;
            MaleNamesCollection = maleNames;
            FemaleNamesCollection = femaleNames;
            LastNamesCollection = lastNames;
        }

        [Theory]
        [InlineData(1000)]
        public void ShouldReturnALastName(int iterations)
        {
            while(iterations-- > 0)
            {
                var name = RandomNameGenerator.GetLastName();
                Assert.Contains(name, LastNamesCollection.Names);
            }
        }


        [Theory]
        [InlineData(1000)]
        public void ShouldReturnAMaleName(int iterations)
        {
            while(iterations-- > 0)
            {
                var name = RandomNameGenerator.GetFirstName(100M);
                Assert.Contains(name, MaleNamesCollection.Names);
            }
        }

        [Theory]
        [InlineData(1000)]
        public void ShouldReturnAFemaleName(int iterations)
        {
            while(iterations-- > 0)
            {
                var name = RandomNameGenerator.GetFirstName(0M);
                Assert.Contains(name, FemaleNamesCollection.Names);
            }
        }

    }
}