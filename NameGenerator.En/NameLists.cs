namespace NameGenerator.En
{
    public abstract class BaseNames<T> : INameList
        where T : new()
    {
        private static T _default;
        public static T Default => _default ??= new T();
        public abstract string[] Names { get; }
    }

    public class MaleNames : BaseNames<MaleNames>
    {
        public override string[] Names { get; } =
        {
            "Noah", "Liam", "Jacob", "Mason", "William", "Ethan", "Michael", "Alexander", "James", "Elijah", "Daniel",
            "Benjamin", "Aiden", "Jayden", "Logan", "Matthew", "David", "Joseph", "Lucas", "Jackson", "Anthony",
            "Joshua", "Samuel", "Andrew", "Gabriel", "Christopher", "John", "Dylan", "Carter", "Isaac", "Ryan", "Luke",
            "Oliver", "Nathan", "Henry", "Owen", "Caleb", "Wyatt", "Christian", "Sebastian", "Jack", "Jonathan",
            "Landon", "Julian", "Isaiah", "Hunter", "Levi", "Aaron", "Eli", "Charles", "Thomas", "Connor", "Brayden",
            "Nicholas", "Jaxon", "Jeremiah", "Cameron", "Evan", "Adrian", "Jordan", "Gavin", "Grayson", "Angel",
            "Robert", "Tyler", "Josiah", "Austin", "Colton", "Brandon", "Jose", "Dominic", "Kevin", "Zachary", "Ian",
            "Chase", "Jason", "Adam", "Ayden", "Parker", "Hudson", "Cooper", "Nolan", "Lincoln", "Xavier", "Carson",
            "Jace", "Justin", "Easton", "Mateo", "Asher", "Bentley", "Blake", "Nathaniel", "Jaxson", "Leo", "Kayden",
            "Tristan", "Luis", "Elias", "Brody", "Bryson", "Juan", "Vincent", "Cole", "Micah", "Ryder", "Theodore",
            "Carlos", "Ezra", "Damian", "Miles", "Santiago", "Max", "Jesus", "Leonardo", "Sawyer", "Diego", "Alex",
            "Roman", "Maxwell", "Eric", "Greyson", "Hayden", "Giovanni", "Wesley", "Axel", "Camden", "Braxton", "Ivan",
            "Ashton", "Declan", "Bryce", "Timothy", "Antonio", "Silas", "Kaiden", "Ezekiel", "Jonah", "Weston",
            "George", "Harrison", "Steven", "Miguel", "Richard", "Bryan", "Kaleb", "Victor", "Aidan", "Jameson", "Joel",
            "Patrick", "Jaden", "Colin", "Everett", "Preston", "Maddox", "Edward", "Alejandro", "Kaden", "Jesse",
            "Emmanuel", "Kyle", "Brian", "Emmett", "Jude", "Marcus", "Kingston", "Kai", "Alan", "Malachi", "Grant",
            "Jeremy", "Riley", "Jayce", "Bennett", "Abel", "Ryker", "Caden", "Brantley", "Luca", "Brady", "Calvin",
            "Sean", "Oscar", "Jake", "Maverick", "Abraham", "Mark", "Tucker", "Nicolas", "Bradley", "Kenneth", "Avery",
            "Cayden", "King", "Paul", "Amir", "Gael", "Graham", "Maximus"
        };
    }

    public class FemaleNames : BaseNames<FemaleNames>
    {
        public override string[] Names { get; } =
        {
            "Emma", "Sophia", "Olivia", "Isabella", "Ava", "Mia", "Abigail", "Emily", "Madison", "Charlotte",
            "Elizabeth", "Amelia", "Chloe", "Ella", "Evelyn", "Avery", "Sofia", "Harper", "Grace", "Addison",
            "Victoria", "Natalie", "Lily", "Aubrey", "Lillian", "Zoey", "Hannah", "Layla", "Brooklyn", "Samantha",
            "Zoe", "Leah", "Scarlett", "Riley", "Camila", "Savannah", "Anna", "Audrey", "Allison", "Aria", "Gabriella",
            "Hailey", "Claire", "Sarah", "Aaliyah", "Kaylee", "Nevaeh", "Penelope", "Alexa", "Arianna", "Stella",
            "Alexis", "Bella", "Nora", "Ellie", "Ariana", "Lucy", "Mila", "Peyton", "Genesis", "Alyssa", "Taylor",
            "Violet", "Maya", "Caroline", "Madelyn", "Skylar", "Serenity", "Ashley", "Brianna", "Kennedy", "Autumn",
            "Eleanor", "Kylie", "Sadie", "Paisley", "Julia", "Mackenzie", "Sophie", "Naomi", "Eva", "Khloe",
            "Katherine", "Gianna", "Melanie", "Aubree", "Piper", "Ruby", "Lydia", "Faith", "Madeline", "Alexandra",
            "Kayla", "Hazel", "Lauren", "Annabelle", "Jasmine", "Aurora", "Alice", "Makayla", "Sydney", "Bailey",
            "Luna", "Maria", "Reagan", "Morgan", "Isabelle", "Rylee", "Kimberly", "Andrea", "London", "Elena",
            "Jocelyn", "Natalia", "Trinity", "Eliana", "Vivian", "Cora", "Quinn", "Liliana", "Molly", "Jade", "Clara",
            "Valentina", "Mary", "Brielle", "Hadley", "Kinsley", "Willow", "Brooke", "Lilly", "Delilah", "Payton",
            "Mariah", "Paige", "Jordyn", "Nicole", "Mya", "Josephine", "Isabel", "Lyla", "Adeline", "Destiny", "Ivy",
            "Emilia", "Rachel", "Angelina", "Valeria", "Kendall", "Sara", "Ximena", "Isla", "Aliyah", "Reese",
            "Vanessa", "Juliana", "Mckenzie", "Amy", "Laila", "Adalynn", "Emery", "Margaret", "Eden", "Gabrielle",
            "Kaitlyn", "Ariel", "Gracie", "Brooklynn", "Melody", "Jessica", "Valerie", "Adalyn", "Adriana", "Elise",
            "Michelle", "Rebecca", "Daisy", "Everly", "Katelyn", "Ryleigh", "Catherine", "Norah", "Alaina", "Athena",
            "Leilani", "Londyn", "Eliza", "Jayla", "Summer", "Lila", "Makenzie", "Izabella", "Daniela", "Stephanie",
            "Julianna", "Rose", "Alana", "Harmony", "Jennifer", "Hayden"
        };
    }

    public class LastNames : BaseNames<LastNames>
    {
        public override string[] Names { get; } =
        {
            "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor",
            "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson",
            "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright",
            "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez",
            "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez",
            "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson",
            "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly",
            "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry",
            "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzales",
            "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes"
        };
    }
}