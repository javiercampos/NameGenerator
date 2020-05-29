namespace NameGenerator.En
{
    public class EnglishNameGenerator : BaseNameGenerator<MaleNames, FemaleNames, LastNames>
    {
        public EnglishNameGenerator() : this(null) { }

        public EnglishNameGenerator(IRandomGenerator randomGenerator) : base(MaleNames.Default, FemaleNames.Default, LastNames.Default, randomGenerator ?? new RngCryptoRandomGenerator())
        {
        }
    }
}
