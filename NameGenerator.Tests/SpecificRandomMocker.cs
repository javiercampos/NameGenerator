namespace NameGenerator.Tests
{
    public class SpecificRandomMocker : IRandomGenerator
    {
        private int _nextInt = 0;
        private byte _nextByte = 0;

        public void SetIntNextValue(int next)
        {
            _nextInt = next;
        }
        public void SetNextByte(byte next)
        {
            _nextByte = next;
        }

        public byte NextRandomByte() => _nextByte;
        public int NextRandomInt() => _nextInt;
    }

    public class MockMaleNames : INameList
    {
        public string[] Names { get; } = new[] {"MaleTestNameA", "MaleTestNameB"};
    }
    public class MockFemaleNames : INameList
    {
        public string[] Names { get; } = new[] {"FemaleTestNameA", "FemaleTestNameB"};
    }
    public class MockLastNames : INameList
    {
        public string[] Names { get; } = new[] {"LastTestNameA", "LastTestNameB"};
    }
}