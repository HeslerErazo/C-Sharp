using System;
using System.Collections.Generic;
using System.IO;


public class FactuCafe {
	
	// Listas publicas del menu y cafe tender
	public List<Cafe> ListadeCafe { get; set; }
	public List<Te> ListadeTe { get; set; }
	public List<Chocolate> ListadeChocolate { get; set; }
	public List<Frios> ListadeFrios { get; set; }
	public List<InventarioCafe> ListadeInventario { get; set; }
	public List<Factura> ListadeFacturas { get; set; }
	public List<CafeTender> ListadeCafeTender { get; set; }
	
	// constructor principal con las listas y funciones
	public FactuCafe () {
		
		ListadeCafe = new List<Cafe> ();
		cargarCafe();
		
		ListadeTe = new List<Te> (); 
		cargarTe();
		
		ListadeChocolate = new List<Chocolate> ();
		cargarChocolate();
		
		ListadeFrios = new List<Frios> ();
		cargarFrios();
		
		ListadeInventario = new List<InventarioCafe> ();
		cargarInventario();
		
		ListadeCafeTender = new List<CafeTender>();
		cargarCafeTender();
		
		ListadeFacturas = new List<Factura> ();
		
	}
	
	// cargar cafe
	private void cargarCafe () {
		
		Cafe c1 = new Cafe ("Americano", "Sencillo", 35, 01);
		ListadeCafe.Add(c1);
		Cafe c2 = new Cafe ("Cappuccino", "Grande", 45, 02);
		ListadeCafe.Add(c2);
		Cafe c3 = new Cafe ("Latte Normal", "Sencillo", 45, 03);
		ListadeCafe.Add(c3);
		Cafe c4 = new Cafe ("Latte Saborizado", "Grande", 65, 04);
		ListadeCafe.Add(c4);
		Cafe c5 = new Cafe ("Mocha Oscuro", "Especial", 60, 05);
		ListadeCafe.Add(c5);
		Cafe c6 = new Cafe ("Mocha Blanco", "Especial", 60, 06);
		ListadeCafe.Add(c6);
		
	}
	
	// enlistar el menu cafe
	public void enlistarCafe () {
		
		Console.Clear();
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("		            	  MENU DE CAFE                           ");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " CAFE " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var cafe in ListadeCafe) {
			
			Console.WriteLine( " \t  "  + cafe.NoOrden + "   \t    " + cafe.Nombre + "   \t    " + cafe.Tipo + "   \t    " + cafe.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
	}
	
	// cargar los te's
	private void cargarTe() {
		
		Te t1 = new Te("Variados Tea", "Especial", 50, 07);
		ListadeTe.Add(t1);
		Te t2 = new Te("Chai Latte", "Especial", 60, 08);
		ListadeTe.Add(t2);
		
	}
	
	// Enlistar el te
	public void enlistarTe (){
		
		Console.Clear();
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("		            	   MENU DE TE                            ");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " CAFE " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var te in ListadeTe) {
			
			Console.WriteLine( " \t  "  + te.NoOrden + "   \t    " + te.Nombre + "   \t    " + te.Tipo + "   \t    " + te.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
	}
	
	// cargar el menu chocolate
	private void cargarChocolate () {
		
		Chocolate ch1 = new Chocolate ("Hot Chocolate", "Bomba", 60, 09);
		ListadeChocolate.Add(ch1);
		Chocolate ch2 = new Chocolate ("Marshmellow", "Especial", 65, 10);
		ListadeChocolate.Add(ch2);
		
	}
	
	// Listar el menu chocolate
	public void enlistarChocolate () {
		
		Console.Clear();
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("		            	MENU DE CHOCOLATE                           ");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " CAFE " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var choco in ListadeChocolate) {
			
			Console.WriteLine( " \t  "  + choco.NoOrden + "   \t    " + choco.Nombre + "   \t    " + choco.Tipo + "   \t    " + choco.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
	}
	
	// Cargar el menu bebidas frias
	private void cargarFrios () {
		
		Frios fr1 = new Frios ("Hershey's Bomb", "Especial", 95, 11);
		ListadeFrios.Add(fr1);
		Frios fr2 = new Frios ("Iced Chai Latte", "Extra", 75, 12);
		ListadeFrios.Add(fr2);
		Frios fr3 = new Frios ("Fruta Normal", "Sencillo", 45, 13);
		ListadeFrios.Add(fr3);
		Frios fr4 = new Frios ("Fruta con Leche", "Grande", 65, 14);
		ListadeFrios.Add(fr4);
		Frios fr5 = new Frios ("Coffee-Oreo", "Especial", 70, 15);
		ListadeFrios.Add(fr5);
		Frios fr6 = new Frios ("Oreo Mocha Supr", "Extra", 75, 16);
		ListadeFrios.Add(fr6);
		Frios fr7 = new Frios ("Piña Colada", "Especial", 85, 17);
		ListadeFrios.Add(fr7);
		Frios fr8 = new Frios ("Limonada Tipica", "Verano", 45, 18);
		ListadeFrios.Add(fr8);
		Frios fr9 = new Frios ("Iced Tea Normal", "Verano", 50, 19);
		ListadeFrios.Add(fr9);
		Frios fr10 = new Frios ("Iced Latte", "Casual", 50, 20);
		ListadeFrios.Add(fr10);
		Frios fr11 = new Frios ("Iced Moccha", "Super", 65, 21);
		ListadeFrios.Add(fr11);
		Frios fr12 = new Frios ("Iced Latte Sabor", "Especial", 75, 22);
		ListadeFrios.Add(fr12);
		
		
	}
	
	// enlistar Bebidas frias
	public void enlistarGranizados() {
		
		Console.Clear();
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("		            MENU DE BEBIDAS FRIAS                           ");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " BEBIDA " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var frio in ListadeFrios) {
			
			Console.WriteLine( " \t  "  + frio.NoOrden + "   \t    " + frio.Nombre + "   \t    " + frio.Tipo + "   \t    " + frio.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
		
	}
	
	// Cargar el menu completo
	private void cargarInventario () {
		
		InventarioCafe ic1 = new InventarioCafe ("Americano", "Sencillo", 35, 01);
		ListadeInventario.Add(ic1);
		InventarioCafe ic2 = new InventarioCafe ("Cappuccino", "Grande", 45, 02);
		ListadeInventario.Add(ic2);
		InventarioCafe ic3 = new InventarioCafe ("Latte Normal", "Sencillo", 45, 03);
		ListadeInventario.Add(ic3);
		InventarioCafe ic4 = new InventarioCafe ("Latte Saborizado", "Grande", 65, 04);
		ListadeInventario.Add(ic4);
		InventarioCafe ic5 = new InventarioCafe ("Mocha Oscuro", "Especial", 60, 05);
		ListadeInventario.Add(ic5);
		InventarioCafe ic6 = new InventarioCafe ("Mocha Blanco", "Especial", 60, 06);
		ListadeInventario.Add(ic6);
		InventarioCafe ic7 = new InventarioCafe ("Variados Tea", "Especial", 50, 07);
		ListadeInventario.Add(ic7);
		InventarioCafe ic8 = new InventarioCafe ("Chai Latte", "Especial", 60, 08);
		ListadeInventario.Add(ic8);
		InventarioCafe ic9 = new InventarioCafe ("Hot Chocolate", "Bomba", 60, 09);
		ListadeInventario.Add(ic9);
		InventarioCafe ic10 = new InventarioCafe ("Marshmellow", "Especial", 65, 10);
		ListadeInventario.Add(ic10);
		InventarioCafe ic11 = new InventarioCafe ("Hershey's Bomb", "Especial", 95, 11);;
		ListadeInventario.Add(ic11);
		InventarioCafe ic12 = new InventarioCafe ("Iced Chai Latte", "Extra", 75, 12);
		ListadeInventario.Add(ic12);
		InventarioCafe ic13 = new InventarioCafe ("Fruta Normal", "Sencillo", 45, 13);
		ListadeInventario.Add(ic13);
		InventarioCafe ic14 = new InventarioCafe ("Fruta con Leche", "Grande", 65, 14);
		ListadeInventario.Add(ic14);
		InventarioCafe ic15 = new InventarioCafe ("Coffee-Oreo", "Especial", 70, 15);
		ListadeInventario.Add(ic15);
		InventarioCafe ic16 = new InventarioCafe ("Oreo Mocha Supr", "Extra", 75, 16);
		ListadeInventario.Add(ic16);
		InventarioCafe ic17 = new InventarioCafe ("Piña Colada", "Especial", 85, 17);
		ListadeInventario.Add(ic17);
		InventarioCafe ic18 = new InventarioCafe ("Limonada Tipica", "Verano", 45, 18);
		ListadeInventario.Add(ic18);
		InventarioCafe ic19 = new InventarioCafe ("Iced Tea Normal", "Verano", 50, 19);
		ListadeInventario.Add(ic19);
		InventarioCafe ic20 = new InventarioCafe ("Iced Latte", "Casual", 50, 20);
		ListadeInventario.Add(ic20);
		InventarioCafe ic21 = new InventarioCafe ("Iced Moccha", "Super", 65, 21);
		ListadeInventario.Add(ic21);
		InventarioCafe ic22 = new InventarioCafe ("Iced Latte Sabor", "Especial", 75, 22);
		ListadeInventario.Add(ic22);
		
	}
	
	// Cargar a los vendedores del cafe
	private void cargarCafeTender () {
		
		CafeTender ct1 = new CafeTender ("Mayra", "Arauz", "3344-3322", 001);
		ListadeCafeTender.Add(ct1);
		CafeTender ct2 = new CafeTender ("Scarleth", "Arauz", "3342-1122", 002);
		ListadeCafeTender.Add(ct2);
		CafeTender ct3 = new CafeTender ("Angie", "Broonfield", "9300-1522", 003);
		ListadeCafeTender.Add(ct3);
		CafeTender ct4 = new CafeTender ("Juan", "Calix", "9100-1522", 004);
		ListadeCafeTender.Add(ct4);
		
	}
	
	//enlistar a los vendedores del cafe
	
	public void enlistarCafeTender () {
		
		Console.Clear();
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("		            	    CAFE TENDER                          ");
		Console.WriteLine("  ************************************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NOMBRE " + " \t " + " APELLIDO " + " \t " + " CODIGO " + " \t " + " TELEFONO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var tender in ListadeCafeTender) {
			
			Console.WriteLine( " \t  "  + tender.Nombre + "   \t    " + tender.Apellido + "   \t    " + tender.CodigoCafeTender + "   \t    " + tender.Telefono);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
		
	}
	
	// Funcion para realizar la factura
	public void facturacion () 
	{
		Console.Clear();
		Console.WriteLine("BIENVENIDO (A) AL SISTEMA");
		Console.WriteLine("-------------------------");
		Console.WriteLine("");
		
		Console.WriteLine("Ingrese el codigo del Cafe Tender: ");
		string nuevoCodigoCafeTender = Console.ReadLine();
		
		CafeTender cafeTender = ListadeCafeTender.Find(c => c.CodigoCafeTender.ToString() == nuevoCodigoCafeTender);
		
		if (cafeTender == null)
		{
			Console.WriteLine("Cafe Tender no encontrado: ");
			Console.ReadLine();
			//return;
		}
		else {
			Console.WriteLine("Nombre Completo: " + cafeTender.Nombre + " | " + cafeTender.Apellido + " Codigo: " + cafeTender.CodigoCafeTender);
			Console.ReadLine();
			Console.WriteLine("");
		}
		
		int nuevoCodigo = ListadeFacturas.Count + 1;
		
		Factura factura = new Factura(nuevoCodigo, DateTime.Now, "Express", cafeTender);
		ListadeFacturas.Add(factura);
		
		//Ciclo while (true) este nos dira si deseamos realizar pedidos
		
		while(true)
        {
		
		Console.WriteLine("Ingrese el numero de orden de su pedido: ");
		string nuevoPedido = Console.ReadLine();
		
		InventarioCafe inventarioCafe = ListadeInventario.Find(ci => ci.NoOrden.ToString() == nuevoPedido);
		
		if (inventarioCafe == null)
		{
			Console.WriteLine("Pedido no encontrado: ");
			Console.ReadLine();
			//return;
		}
		else {
			Console.WriteLine("Descripcion: " + inventarioCafe.Nombre + " Precio: " + inventarioCafe.Precio + " Tipo: " + inventarioCafe.Tipo);
			factura.agregarPedido(inventarioCafe); //Invocar funcion agregarPedido
			Console.WriteLine("");
		}
		
			Console.WriteLine("");
		    Console.WriteLine("Realizar otro pedido? Presione s/n");
            string realizarPedido = Console.ReadLine();
            if (realizarPedido.ToLower() == "n") {
                break;
            }
        }
    	
		Console.WriteLine("");
		Console.WriteLine("Subtotal: " + factura.Subtotal);
		Console.WriteLine("ISV - Impuesto: " + factura.Isv);
		Console.WriteLine("Total: " + factura.Total );
		Console.WriteLine("GRACIAS POR PREFERIRNOS, BRINDANDO CALIDAD A SU PALADAR");	
		Console.ReadLine();
		
		/*Console.WriteLine("Ingrese efectivo pagado: "); PENDIENTE
    	factura.ValorPago = Console.ReadLine();
    	Console.WriteLine("Cambio: " + factura.Cambio);
		Console.ReadLine();*/
		
	}
	
	public void faturasRealizadas() {
		
		Console.Clear();
		Console.WriteLine("*********************************************************************");
		Console.WriteLine("                               FACTURA                               ");
		Console.WriteLine("                          CAFE PATAGOTITAN                           ");
		Console.WriteLine("               Disfruta del Buen Cafe, como Dios manda               ");
		Console.WriteLine("*********************************************************************");
		Console.WriteLine("---------------------------------------------------------------------");
		Console.WriteLine("");
		Console.WriteLine(" \t\t " + " FECHA " + " \t\t " + "   PEDIDO  " + " \t " + " VENDEDOR ");
		Console.WriteLine("");
		
		foreach (var imprimir in ListadeFacturas) {
			
			Console.WriteLine( " \t  "  + imprimir.Fecha + "   \t    " + imprimir.NumerodePedido + "   \t    " + imprimir.CafeTender.Nombre );
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("SUBTOTAL: " + imprimir.Subtotal);
			Console.WriteLine("IMPUESTO: " + imprimir.Isv);
			Console.WriteLine("TOTAL: " + imprimir.Total);
			Console.WriteLine("");
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("");
		
			foreach (var imprimir2 in imprimir.ListaDetalledeFactura) {
				
				//Console.WriteLine("");
				//Console.WriteLine( "  "  + "DESCRIPCION PEDIDO" + "      " + "CANTIDAD" + "      " + "PRECIO" );
				Console.WriteLine( "  "  + imprimir2.InventarioCafe.Nombre + "      " + imprimir2.Cantidad + "      " + imprimir2.Precio );
				Console.WriteLine("---------------------------------------------------------------------");
		
			}
			Console.WriteLine();
		}
	    Console.ReadLine();	
	}
	
	// Imprimir factura en archivo txt
	public void imprimirFactura() {
		
		TextWriter factura; // Declaramos el tipo de dato TextWriter
    	
    	factura = new StreamWriter ("C:\\Users\\Hesler\\Desktop\\PROYECTO FINAL\\SistemaCafe\\bin\\Debug\\netcoreapp3.1\\factura.txt"); // Guardamos en StreamWriter como factura.txt
		
    	Console.Clear();
		factura.WriteLine("*********************************************************************");
		factura.WriteLine("                               FACTURA                               ");
		factura.WriteLine("                          CAFE PATAGOTITAN                           ");
		factura.WriteLine("               Disfruta del Buen Cafe, como Dios manda               ");
		factura.WriteLine("*********************************************************************");
		factura.WriteLine("---------------------------------------------------------------------");
		factura.WriteLine("");
		factura.WriteLine(" \t\t " + " FECHA " + " \t\t " + "   PEDIDO  " + " \t " + " VENDEDOR ");
		factura.WriteLine("");
		
		foreach (var imprimir in ListadeFacturas) {
			
			factura.WriteLine( " \t  "  + imprimir.Fecha + "   \t    " + imprimir.NumerodePedido + "   \t    " + imprimir.CafeTender.Nombre );
			factura.WriteLine("---------------------------------------------------------------------");
			factura.WriteLine("");
			factura.WriteLine("SUBTOTAL: " + imprimir.Subtotal);
			factura.WriteLine("IMPUESTO: " + imprimir.Isv);
			factura.WriteLine("TOTAL: " + imprimir.Total);
			factura.WriteLine("");
			factura.WriteLine("---------------------------------------------------------------------");
			factura.WriteLine("");
		
			foreach (var imprimir2 in imprimir.ListaDetalledeFactura) {
				
				factura.WriteLine( "  "  + imprimir2.InventarioCafe.Nombre + "      " + imprimir2.Cantidad + "      " + imprimir2.Precio );
				factura.WriteLine("---------------------------------------------------------------------");
				
			}
			
			//Console.WriteLine();
		}
		Console.WriteLine("Guardando factura, lista para imprimir");
	    Console.ReadLine(); 
		factura.Close(); 	    
	}
}