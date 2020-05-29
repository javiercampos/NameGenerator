namespace NameGenerator.Tests
{
    public class NameGeneratorBaseFixture : BaseNameGenerator<MockMaleNames, MockFemaleNames, MockLastNames>
    {
        public NameGeneratorBaseFixture(IRandomGenerator generator) : base(new MockMaleNames(), new MockFemaleNames(), new MockLastNames(), generator)
        {
        }
    }
}

