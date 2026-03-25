// See https://aka.ms/new-console-template for more information
// ================================================================
// ====================== INVENTARIO APP ========================
// ================================================================

using System.Diagnostics;
using System.Reflection;
var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

ShowBanner();
Console.WriteLine("Ingrese el nombre del producto:");
// string nombre = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto:");
// float precio = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad del producto:");

Console.WriteLine($"Version: {version}");

int quantity = 0;
decimal price = 0.00m;
bool isValid = false;
string name = "";

do {
    Console.WriteLine("Ingrese el nombre del producto:");
    name = Console.ReadLine() ?? "";
    if (string.IsNullOrEmpty(name)) {
        Console.WriteLine("El nombre del producto no puede ser vacío");
    }
} while (!isValid);
if ( args.Length > 0 ) {
    switch (args[0].ToLower()) {
        case "add":
            Console.WriteLine("Agregar producto");
            break;
        case "list":
            Console.WriteLine("Listar productos");
            break;
        case "remove":
            Console.WriteLine("Eliminar producto");
            break;
        default:
            Console.WriteLine("Comando no válido");
            Environment.Exit(1);
            break;
    }
} else {
    Console.WriteLine("No se proporcionaron argumentos");
    Environment.Exit(1);
}

void ShowBanner() {
    Console.WriteLine("================================================================");
    Console.WriteLine("====================== INVENTARIO APP ========================");
    Console.WriteLine("================================================================");
}