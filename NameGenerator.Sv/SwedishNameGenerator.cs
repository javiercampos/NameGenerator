namespace NameGenerator.Sv
{
    public class SwedishNameGenerator : BaseNameGenerator<MaleNames, FemaleNames, LastNames>
    {
        public SwedishNameGenerator() : this(null) { }

        public SwedishNameGenerator(IRandomGenerator randomGenerator) : base(MaleNames.Default, FemaleNames.Default, LastNames.Default, randomGenerator ?? new RngCryptoRandomGenerator())
        {
        }
    }
}
