namespace NameGenerator.Sv
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
            "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Jan", "Gustav", "Hans",
            "Peter", "Lennart", "Gunnar", "Sven", "Fredrik", "Thomas", "Daniel", "Bengt", "Bo", "Alexander", "Oskar",
            "Göran", "Åke", "Christer", "Andreas", "Stefan", "Magnus", "Martin", "John", "Mattias", "Mats", "Mohamed",
            "Henrik", "Leif", "Ulf", "Jonas", "Björn", "Axel", "Robert", "Bertil", "Christian", "Marcus", "Arne",
            "Viktor", "David", "Emil", "Niklas", "Ingemar", "Patrik", "Håkan", "Kjell", "Christoffer", "Rickard",
            "Stig", "Rolf", "Joakim", "William", "Wilhelm", "Filip", "Tommy", "Roland", "Simon", "Claes", "Sebastian",
            "Anton", "Roger", "Ingvar", "Kent", "Johannes", "Ove", "Tobias", "Jakob", "Jonathan", "Kenneth", "Hugo",
            "Elias", "Emanuel", "Lucas", "Adam", "Jörgen", "Robin", "Kurt", "Ali", "Rune", "Gösta", "Georg", "Josef",
            "Oliver", "Johnny", "Linus", "Arvid", "Isak", "Ludvig", "Albin", "Torbjörn", "Sten", "Dan", "Edvin"
        };
    }

    public class FemaleNames : BaseNames<FemaleNames>
    {
        public override string[] Names { get; } =
        {
            "Maria", "Elisabeth", "Anna", "Kristina", "Margareta", "Eva", "Linnéa", "Karin", "Birgitta", "Marie",
            "Ingrid", "Sofia", "Marianne", "Lena", "Kerstin", "Sara", "Helena", "Emma", "Katarina", "Johanna",
            "Viktoria", "Inger", "Cecilia", "Susanne", "Monica", "Elin", "Therese", "Jenny", "Hanna", "Anita", "Louise",
            "Irene", "Carina", "Ann", "Ida", "Linda", "Gunilla", "Helen", "Ulla", "Viola", "Malin", "Annika",
            "Ingegerd", "Elsa", "Matilda", "Josefin", "Ulrika", "Sofie", "Anette", "Alice", "Julia", "Astrid",
            "Caroline", "Anneli", "Barbro", "Emelie", "Kristin", "Karolina", "Lisa", "Åsa", "Amanda", "Camilla",
            "Madeleine", "Siv", "Lovisa", "Erika", "Yvonne", "Agneta", "Charlotte", "Britt", "Maja", "Rut", "Sandra",
            "Gun", "Rebecca", "Frida", "Alexandra", "Isabelle", "Ellinor", "Berit", "Jessica", "Emilia", "Ebba",
            "Ellen", "Klara", "Märta", "Charlotta", "Ann-Marie", "Olivia", "Inga", "Agnes", "Sonja", "Ann-Christin",
            "Pia", "Maj", "Mona", "Ingeborg", "Felicia", "Nathalie", "Ella"
        };
    }

    public class LastNames : BaseNames<LastNames>
    {
        public override string[] Names { get; } =
        {
            "Andersson", "Johansson", "Karlsson", "Nilsson", "Eriksson", "Larsson", "Olsson", "Persson", "Svensson",
            "Gustafsson", "Pettersson", "Jonsson", "Jansson", "Hansson", "Bengtsson", "Jönsson", "Lindberg",
            "Jakobsson", "Magnusson", "Olofsson", "Lindström", "Lindqvist", "Lindgren", "Axelsson", "Berg", "Bergström",
            "Lundberg", "Lind", "Lundgren", "Lundqvist", "Mattsson", "Berglund", "Fredriksson", "Sandberg",
            "Henriksson", "Forsberg", "Sjöberg", "Wallin", "Ali", "Engström", "Mohamed", "Eklund", "Danielsson",
            "Lundin", "Håkansson", "Björk", "Bergman", "Gunnarsson", "Holm", "Wikström", "Samuelsson", "Isaksson",
            "Fransson", "Bergqvist", "Nyström", "Holmberg", "Arvidsson", "Löfgren", "Söderberg", "Nyberg", "Blomqvist",
            "Claesson", "Nordström", "Mårtensson", "Lundström", "Ahmed", "Viklund", "Björklund", "Eliasson", "Pålsson",
            "Hassan", "Berggren", "Sandström", "Lund", "Nordin", "Ström", "Åberg", "Hermansson", "Ekström", "Falk",
            "Holmgren", "Dahlberg", "Hellström", "Hedlund", "Sundberg", "Sjögren", "Ek", "Blom", "Abrahamsson",
            "Martinsson", "Öberg", "Andreasson", "Strömberg", "Månsson", "Åkesson", "Hansen", "Norberg", "Lindholm",
            "Dahl", "Jonasson"
        };
    }
}