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
        Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
        Console.WriteLine("1. Gestionar sabores");
        Console.WriteLine("2. Salir");
    }
}