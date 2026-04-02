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
<<<<<<< HEAD
            Console.WriteLine("2. Listar sabores");
            Console.WriteLine("3. Salir");
=======
            Console.WriteLine("2. Salir");
>>>>>>> d3bc144af7f4e8864a17c79480989d96b080cfbc

            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearSabor(service);
                    break;
<<<<<<< HEAD
                case 2:
                    ListarSabores(service);
                    break;
            }

        } while (opcion != 3);
=======
            }

        } while (opcion != 2);
>>>>>>> d3bc144af7f4e8864a17c79480989d96b080cfbc
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
<<<<<<< HEAD

    static void ListarSabores(SaborService service)
    {
        var lista = service.ObtenerTodos();

        Console.WriteLine("\n--- LISTA DE SABORES ---");

        foreach (var s in lista)
        {
            Console.WriteLine($"{s.Id} - {s.Nombre} - {s.Descripcion} - {s.Precio}");
        }
    }
=======
>>>>>>> d3bc144af7f4e8864a17c79480989d96b080cfbc
}