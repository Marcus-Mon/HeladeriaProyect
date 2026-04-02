using HeladeriaProyect.Services;
using HeladeriaProyecto.Entities;
using HeladeriaProyecto.Services;

class Program
{
    static void Main(string[] args)
    {
        UsuarioService usuarioService = new UsuarioService();

        Console.WriteLine("=== LOGIN HELADERÍA ===");

        Console.Write("Usuario: ");
        string user = Console.ReadLine();

        Console.Write("Contraseña: ");
        string pass = Console.ReadLine();

        bool loginExitoso = usuarioService.Login(user, pass);

        if (loginExitoso)
        {
            Console.WriteLine("Login correcto. Bienvenido!");
            MostrarMenu();
        }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos");
        }

        Console.ReadLine();
    }

    static void MostrarMenu()
    {
        SaborService service = new SaborService();
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
            Console.WriteLine("1. Crear sabor");
            Console.WriteLine("2. Salir");

            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearSabor(service);
                    break;
            }

        } while (opcion != 2);
    }

    static void CrearSabor(SaborService service)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Descripción: ");
        string desc = Console.ReadLine();

        Console.Write("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        service.Crear(new SaborHelado
        {
            Nombre = nombre,
            Descripcion = desc,
            Precio = precio
        });

        Console.WriteLine("Sabor creado correctamente");
        Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
        Console.WriteLine("1. Gestionar sabores");
        Console.WriteLine("2. Salir");
    }
}