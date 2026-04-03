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
            Console.WriteLine("2. Listar sabores");
            Console.WriteLine("3. Editar sabor");
            Console.WriteLine("4. Eliminar sabor");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearSabor(service);
                    break;
                case 2:
                    ListarSabores(service);
                    break;
                case 3:
                    EditarSabor(service);
                    break;
                case 4:
                    EliminarSabor(service);
                    break;
            }

        } while (opcion != 5);
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
    }

    static void ListarSabores(SaborService service)
    {
        var lista = service.ObtenerTodos();

        Console.WriteLine("\n--- LISTA DE SABORES ---");

        foreach (var s in lista)
        {
            Console.WriteLine($"{s.Id} - {s.Nombre} - {s.Descripcion} - {s.Precio}");
        }
    }

    static void EditarSabor(SaborService service)
    {
        Console.Write("ID del sabor a editar: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nuevo nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Nueva descripción: ");
        string desc = Console.ReadLine();

        Console.Write("Nuevo precio: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        service.Actualizar(new SaborHelado
        {
            Id = id,
            Nombre = nombre,
            Descripcion = desc,
            Precio = precio
        });

        Console.WriteLine("Sabor actualizado correctamente");
    }

    static void EliminarSabor(SaborService service)
    {
        Console.Write("ID del sabor a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        service.Eliminar(id);

        Console.WriteLine("Sabor eliminado correctamente");
    }
}