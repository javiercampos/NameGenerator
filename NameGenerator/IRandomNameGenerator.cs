namespace NameGenerator
{
    public interface IRandomNameGenerator
    {
        string GetFullName(decimal maleProbability = 50);
        string GetFirstName(decimal maleProbability = 50);
        string GetLastName();
    }
}
