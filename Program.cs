using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pantalla02
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static List<string> inventario = new List<string>();
        static void Main()
        {
            int opcion;

            do
            {
                MostrarMenuGestionProductos();
                opcion = ObtenerOpcion();
                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        EliminarProducto();
                        break;
                    case 3:
                        ModificarProducto();
                        break;
                    case 4:
                        MostrarInventario();
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al Menú Principal");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                        break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 5);
        }

        static void MostrarMenuGestionProductos()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("||       Gestionar Productos - Mi Tiendita      ||");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|| 1. Agregar Producto                          ||");
            Console.WriteLine("|| 2. Eliminar Producto                         ||");
            Console.WriteLine("|| 3. Modificar Producto                        ||");
            Console.WriteLine("|| 4. Mostrar Inventario                        ||");
            Console.WriteLine("|| 5. Volver al Menú Principal                  ||");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Seleccione una opción:");
        }

        static int ObtenerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
            return opcion;
        }

        static void AgregarProducto()
        {
            Console.WriteLine("Ingrese el nombre del nuevo producto:");
            string nuevoProducto = Console.ReadLine();
            inventario.Add(nuevoProducto);
            Console.WriteLine($"Producto '{nuevoProducto}' agregado al inventario.");
        }

        static void EliminarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto a eliminar:");
            string productoEliminar = Console.ReadLine();

            if (inventario.Contains(productoEliminar))
            {
                inventario.Remove(productoEliminar);
                Console.WriteLine($"Producto '{productoEliminar}' eliminado del inventario.");
            }
            else
            {
                Console.WriteLine($"El producto '{productoEliminar}' no existe en el inventario.");
            }
        }

        static void ModificarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto a modificar:");
            string productoModificar = Console.ReadLine();

            if (inventario.Contains(productoModificar))
            {
                Console.WriteLine("Ingrese el nuevo nombre para el producto:");
                string nuevoNombre = Console.ReadLine();

                inventario[inventario.IndexOf(productoModificar)] = nuevoNombre;
                Console.WriteLine($"Producto '{productoModificar}' modificado a '{nuevoNombre}'.");
            }
            else
            {
                Console.WriteLine($"El producto '{productoModificar}' no existe en el inventario.");
            }
        }

        static void MostrarInventario()
        {
            Console.WriteLine("Inventario Actual:");
            foreach (var producto in inventario)
            {
                Console.WriteLine(producto);
            }
        }
    }


}
