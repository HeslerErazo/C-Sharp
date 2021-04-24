using System; // libreria principal
using System.IO; //Funcion de archivos 
using System.Threading; //para las funciones sleep


namespace SistemaCafe
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			string usuario;
			string contrasena; // Agregar Logeo
			
			//Console.Clear();
			Console.WriteLine("Cafe System/Version 1.2 C# Console");
			Console.WriteLine();
			Console.Write("ServerCafe" + "@" + "login: "); 
			usuario = Console.ReadLine();
			Console.Write("password: ");
			contrasena = Console.ReadLine();
			
			if (usuario == "Admin" && contrasena == "12345678" || usuario == "C#POO" && contrasena == "123456") {
			
			Console.Clear();
			Console.WriteLine("***Cargando***");
			Thread.Sleep(1000); // Temporizador de 1000 milisegundos
							
			FactuCafe factuCafe = new FactuCafe(); // Llamada a clase FactuCafe, donde el proceso se realiza
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t ===========================================================  ");
                Console.WriteLine("\t||  ****************************************************** || ");
                Console.WriteLine("\t||                      SISTEMA DE CAFE                    || ");
                Console.WriteLine("\t||  ****************************************************** || ");
                Console.WriteLine("\t ===========================================================  ");
                Console.WriteLine("\t                        Cafe Patepluma                        ");
                Console.WriteLine("\t            Disfruta del Buen Cafe, como Dios manda           ");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t     BEBIDAS CALIENTES");
                Console.WriteLine("\t\t\t     1 - Menu de Cafe");
                Console.WriteLine("\t\t\t     2 - Menu de Te");
                Console.WriteLine("\t\t\t     3 - Menu de Chocolate");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t     BEBIDAS FRIAS");
                Console.WriteLine("\t\t\t     4 - Menu de Granizados y Hielo");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t     CAFE TENDER EN SERVICIO");
                Console.WriteLine("\t\t\t     5 - Anfitriones del Cafe");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t     SALIDAS DE FACTURAS");
                Console.WriteLine("\t\t\t     6 - Facturar Pedido");
                Console.WriteLine("\t\t\t     7 - Facturas Realizadas");
                Console.WriteLine("\t\t\t     8 - Imprimir Facturas");
                Console.WriteLine("\t\t\t     0 - Salir");
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opcion del Menu");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                		factuCafe.enlistarCafe();
                        break;
                    case "2":
                        factuCafe.enlistarTe();
                        break;
                    case "3":
                        factuCafe.enlistarChocolate();
                        break;
                    case "4":
                       factuCafe.enlistarGranizados();
                        break;      
                    case "5":
                        factuCafe.enlistarCafeTender();
                        break;
					case "6":
                        factuCafe.facturacion();
                        break;
                    case "7":
                        factuCafe.faturasRealizadas();
                        break;
                    case "8":
                        factuCafe.imprimirFactura();
                        break;
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
		else {
				Console.Clear();
				Console.WriteLine("Mistake: User or Password"); // Mensaje de error
				Console.ReadLine();
			}				
		}				
	}
}