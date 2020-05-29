namespace NameGenerator.Es
{
    public class SpanishNameGenerator : BaseNameGenerator<MaleNames, FemaleNames, LastNames>
    {
        public SpanishNameGenerator() : this(null) { }

        public SpanishNameGenerator(IRandomGenerator randomGenerator) : base(MaleNames.Default, FemaleNames.Default, LastNames.Default, randomGenerator ?? new RngCryptoRandomGenerator())
        {
        }
        public override string GetFullName(decimal maleProbability = 50)
        {
            return string.Join(" ", GetFirstName(maleProbability), GetLastName(), GetLastName());
        }

    }
}
