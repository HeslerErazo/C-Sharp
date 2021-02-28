using System;

namespace inventario
{
    class Program
    {
        static string[,] productos = new string[5,5]
        {
            { "001", "iPhoneX", "0", "0", "L"},
            { "002", "Laptop Dell", "5", "0", "L" },
            { "003", "Monitor Samsung", "2", "0", "L" },
            { "004", "Mouse", "100", "0", "L" },
            { "005", "Headset", "25","0", "L" },
        };

        static void listarProductos() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo | Descripcion | Existencia | Entradas y salidas de dinero");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i, 0] + " | " + productos[i, 1] + " | " + productos[i, 2] + "|" + productos[i,3]+ "|" + productos[i,4]);
            }

            Console.ReadLine();
        }

        static void movimientoInventario(string codigo, int cantidad, int precio,  string tipoMovimiento) {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                    } else {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
                    if (tipoMovimiento == "+") {
                        productos[i, 3] = (Int32.Parse(productos[i, 3]) + precio * cantidad).ToString();
                    } else {
                        productos[i, 3] = (Int32.Parse(productos[i, 3]) - precio * cantidad).ToString();
                    }
                }
            }
        }

        static void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";
            string precio ="";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.Write("Ingrese la entrada de dinero: ");
            precio = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), Int32.Parse(precio), "+");
        }

        static void SalidadeInventario() {
            string codigo = "";
            string cantidad = "";
            string precio ="";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.Write("Ingrese la salida de dinero: ");
            precio = Console.ReadLine();


            movimientoInventario(codigo, Int32.Parse(cantidad), Int32.Parse(precio), "-");
        }

        
        static void AjustePositivo() {
            string codigo = "";
            string cantidad = "";
            string precio ="";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingrese el Ajuste al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.Write("Ingrese la entrada de dinero: ");
            precio = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), Int32.Parse(precio), "+");
        }

        static void AjusteNegativo() {
            string codigo = "";
            string cantidad = "";
            string precio ="";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingrese el Ajuste al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.Write("Ingrese la salida de dinero: ");
            precio = Console.ReadLine();


            movimientoInventario(codigo, Int32.Parse(cantidad), Int32.Parse(precio), "-");
        }

        
        static void Main(string[] args)
        {
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Ajuste Positivo de Inventario");
                Console.WriteLine("5 - Ajuste Negativo de Inventario");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        listarProductos();
                        break;
                    case "2":
                        ingresoDeInventario();
                        break;
                    case "3":
                        SalidadeInventario();
                        break;
                    case "4":
                        AjustePositivo();
                        break;
                    case "5":
                        AjusteNegativo();
                        break;
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}