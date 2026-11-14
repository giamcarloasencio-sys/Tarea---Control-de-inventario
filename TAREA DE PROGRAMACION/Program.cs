using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Control de inventario - TecnoPunto ===");
            Console.WriteLine();

            // Tres objetos con variables separadas (sin arreglos ni listas)
            Producto producto1 = LeerProducto(1);
            Producto producto2 = LeerProducto(2);
            Producto producto3 = LeerProducto(3);

            Console.WriteLine();
            Console.WriteLine("=== Productos registrados ===");
            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        // Pide los datos de un producto por teclado y lo crea.
        // Si algo viene mal, muestra el error y vuelve a pedir los datos,
        // así el programa no se cierra de golpe.
        static Producto LeerProducto(int numero)
        {
            while (true)
            {
                Console.WriteLine("--- Producto " + numero + " ---");

                Console.Write("Código: ");
                string codigo = Console.ReadLine();

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Precio: ");
                string textoPrecio = Console.ReadLine();

                Console.Write("Cantidad: ");
                string textoCantidad = Console.ReadLine();

                try
                {
                    // Primero reviso que el precio y la cantidad sean números
                    if (!decimal.TryParse(textoPrecio, out decimal precio))
                    {
                        throw new FormatException("El precio debe ser un número.");
                    }

                    if (!int.TryParse(textoCantidad, out int cantidad))
                    {
                        throw new FormatException("La cantidad debe ser un número entero.");
                    }

                    // Si el constructor encuentra un dato inválido lanza una excepción
                    Producto producto = new Producto(codigo, nombre, precio, cantidad);
                    Console.WriteLine("Producto registrado correctamente.");
                    Console.WriteLine();
                    return producto;
                }
                catch (ArgumentException ex)
                {
                    // Errores de las validaciones de Producto
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Intente de nuevo.");
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    // Errores cuando escriben letras donde van números
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Intente de nuevo.");
                    Console.WriteLine();
                }
            }
        }
    }
}
