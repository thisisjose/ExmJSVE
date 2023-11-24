namespace ExmJSVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada list = new ListaEnlazada();
            Console.WriteLine($"LA LISTA ESTÁ VACÍA: {list.EstaVacia()}");
            Console.WriteLine($"LA LISTA ESTÁ LLENA: {list.EstaLlena()}");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("FAVOR DE INGRESAR LOS SIGUIENTES DATOS XD");
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");

                Persona persona = new Persona(nombre, edad);
                list.InsertarFinal(persona);
            }
            Console.WriteLine($"LA LISTA ESTÁ VACÍA: {list.EstaVacia()}");
            Console.WriteLine("LISTA DE PERSONAS");
            list.Mostrar();

            Console.WriteLine("AGREGAR 2 PERSONAS MÁS A LA LISTA:");
            Console.WriteLine("Nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre: ");
            string name3 = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad4 = Convert.ToInt32(Console.ReadLine());

            Persona person = new Persona(name, edad2);
            list.InsertarFinal(person);
            Console.WriteLine("LISTA DE PERSONES");
            list.Mostrar();

            

        }
    }
}

