namespace NameGenerator.Es
{
    public abstract class BaseNames<T> : INameList
    where T: new()
    {
        private static T _default;
        public static T Default => _default ??= new T();
        public abstract string[] Names { get; }
    }
    public class MaleNames : BaseNames<MaleNames>
    {
        public override string[] Names { get; } =
        {
            "Antonio", "Manuel", "Jose", "Francisco", "David", "Juan", "Jose Antonio", "Javier", "Daniel", "Jose Luis",
            "Francisco Javier", "Carlos", "Jesus", "Alejandro", "Miguel", "Jose Manuel", "Rafael", "Miguel Angel",
            "Pedro", "Pablo", "Angel", "Sergio", "Jose Maria", "Fernando", "Jorge", "Luis", "Alberto", "Juan Carlos",
            "Alvaro", "Adrian", "Juan Jose", "Diego", "Raul", "Ivan", "Juan Antonio", "Ruben", "Enrique", "Oscar",
            "Ramon", "Vicente", "Andres", "Juan Manuel", "Joaquin", "Santiago", "Victor", "Eduardo", "Mario", "Roberto",
            "Jaime", "Francisco Jose", "Marcos", "Ignacio", "Alfonso", "Jordi", "Hugo", "Ricardo", "Salvador",
            "Guillermo", "Emilio", "Gabriel", "Marc", "Gonzalo", "Julio", "Julian", "Mohamed", "Jose Miguel", "Tomas",
            "Martin", "Agustin", "Jose Ramon", "Nicolas", "Ismael", "Joan", "Felix", "Samuel", "Cristian", "Aitor",
            "Lucas", "Hector", "Juan Francisco", "Iker", "Josep", "Jose Carlos", "Alex", "Mariano", "Domingo",
            "Sebastian", "Alfredo", "Cesar", "Jose Angel", "Felipe", "Jose Ignacio", "Victor Manuel", "Rodrigo",
            "Luis Miguel", "Mateo", "Jose Francisco", "Juan Luis", "Xavier", "Albert"
        };
    }

    public class FemaleNames : BaseNames<FemaleNames>
    {
        public override string[] Names { get; } =
        {
            "Maria Carmen", "Maria", "Carmen", "Ana Maria", "Josefa", "Isabel", "Maria Pilar", "Maria Dolores", "Laura",
            "Maria Teresa", "Ana", "Cristina", "Marta", "Maria Angeles", "Francisca", "Lucia", "Maria Isabel",
            "Maria Jose", "Antonia", "Dolores", "Sara", "Paula", "Elena", "Maria Luisa", "Raquel", "Rosa Maria",
            "Pilar", "Concepcion", "Manuela", "Maria Jesus", "Mercedes", "Julia", "Beatriz", "Nuria", "Silvia",
            "Rosario", "Juana", "Alba", "Irene", "Teresa", "Encarnacion", "Patricia", "Montserrat", "Andrea", "Rocio",
            "Monica", "Rosa", "Alicia", "Maria Mar", "Sonia", "Sandra", "Angela", "Marina", "Susana", "Natalia",
            "Yolanda", "Margarita", "Maria Josefa", "Claudia", "Eva", "Maria Rosario", "Inmaculada", "Sofia",
            "Maria Mercedes", "Carla", "Ana Isabel", "Esther", "Noelia", "Veronica", "Angeles", "Nerea", "Carolina",
            "Maria Victoria", "Eva Maria", "Ines", "Miriam", "Maria Rosa", "Daniela", "Lorena", "Ana Belen",
            "Maria Elena", "Maria Concepcion", "Victoria", "Amparo", "Maria Antonia", "Catalina", "Martina", "Lidia",
            "Alejandra", "Celia", "Maria Nieves", "Consuelo", "Olga", "Ainhoa", "Fatima", "Gloria", "Emilia",
            "Maria Soledad", "Clara", "Maria Cristina"
        };
    }

    public class LastNames : BaseNames<LastNames>
    {
        public override string[] Names { get; } =
        {
            "Garcia", "Rodriguez", "Gonzalez", "Fernandez", "Lopez", "Martinez", "Sanchez", "Perez", "Gomez", "Martin",
            "Jimenez", "Ruiz", "Hernandez", "Diaz", "Moreno", "Muñoz", "Alvarez", "Romero", "Alonso", "Gutierrez",
            "Navarro", "Torres", "Dominguez", "Vazquez", "Ramos", "Gil", "Ramirez", "Serrano", "Blanco", "Molina",
            "Morales", "Suarez", "Ortega", "Delgado", "Castro", "Ortiz", "Marin", "Rubio", "Sanz", "Nuñez", "Medina",
            "Iglesias", "Cortes", "Castillo", "Garrido", "Santos", "Lozano", "Guerrero", "Cano", "Prieto", "Mendez",
            "Cruz", "Flores", "Herrera", "Gallego", "Marquez", "Leon", "Peña", "Calvo", "Cabrera", "Vidal", "Campos",
            "Vega", "Fuentes", "Carrasco", "Reyes", "Diez", "Caballero", "Nieto", "Aguilar", "Santana", "Pascual",
            "Herrero", "Montero", "Hidalgo", "Gimenez", "Lorenzo", "Ibañez", "Vargas", "Santiago", "Duran", "Ferrer",
            "Benitez", "Mora", "Arias", "Vicente", "Carmona", "Crespo", "Roman", "Soto", "Pastor", "Velasco", "Saez",
            "Rojas", "Moya", "Parra", "Soler", "Bravo", "Gallardo", "Esteban"
        };
    }
}

