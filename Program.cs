// See https://aka.ms/new-console-template for more information
// ================================================================
// ====================== INVENTARIO APP ========================
// ================================================================

using System.Reflection;
var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("================================================================");
Console.WriteLine("====================== INVENTARIO APP ========================");
Console.WriteLine("================================================================");

Console.WriteLine("Ingrese el nombre del producto:");
// string nombre = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto:");
// float precio = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad del producto:");

Console.WriteLine($"Version: {version}");