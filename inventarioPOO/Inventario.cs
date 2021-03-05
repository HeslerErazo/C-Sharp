using System;
using System.Collections.Generic;

public class Inventario
{
    public List<Producto> ListadeProductos { get; set; }
    public Inventario()
    {
        ListadeProductos = new List<Producto>();

        Producto a = new Producto("001", "iPhoneX", 0, 0, "Lempiras");
        Producto b = new Producto("002", "Dell", 5, 0, "Lempiras");
        Producto c = new Producto("003", "Monitor Samsung", 2, 0, "Lempiras");
        Producto d = new Producto("004", "Mouse", 100, 0,"Lempiras");
        Producto e = new Producto("005", "Headset", 25, 0, "Lempiras");

        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);
    }

    
    public void listarProductos() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo | Descripcion | Existencia | Entrada y Salida de dinero");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia + " | " + producto.Entrada + " " + producto.Dinero.ToString());
        }

        Console.ReadLine();
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }

    private void movimientoEntrada(string codigo, int cantidad, float entrada, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
                if (tipoMovimiento == "+") {
                    producto.Entrada = producto.Entrada + entrada * cantidad;
                } else {
                    producto.Entrada = producto.Entrada - entrada * cantidad;
                }
            }         
        }
    }


    public void ingresoDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

    public void salidaDeInventario (){
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }

    public void ajustePositivo() {
        string codigo = "";
        string cantidad = "";
        string entrada = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        Console.Write("Ingrese la entrada: ");
        entrada = Console.ReadLine();

        movimientoEntrada(codigo, Int32.Parse(cantidad), Convert.ToSingle(entrada), "+");
    }

    public void ajusteNegativo() {
        string codigo = "";
        string cantidad = "";
        string entrada = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        Console.Write("Ingrese la salida: ");
        entrada = Console.ReadLine();

        movimientoEntrada(codigo, Int32.Parse(cantidad), Convert.ToSingle(entrada), "-");
    }
}
