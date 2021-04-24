using System;
using System.Collections.Generic;

public class Factura {
	
	public int Codigo { get; set; }
	public DateTime Fecha { get; set; }
    public string NumerodePedido { get; set; }
    public CafeTender CafeTender { get; set; }
    public List<DetalledeFactura> ListaDetalledeFactura { get; set; }
    public double Total { get; set; }
    public double Subtotal { get; set; }
    public double Isv { get; set; }
    //public string ValorPago { get; set; }
   // public double Cambio { get; set; }
    
    
    public Factura (int codigo, DateTime fecha, string numerodePedido, CafeTender cafeTender)
    {
    	Codigo = codigo;
    	Fecha = fecha;
    	NumerodePedido = numerodePedido;
    	CafeTender = cafeTender;
    	ListaDetalledeFactura = new List<DetalledeFactura>();
    }
    
    public void agregarPedido (InventarioCafe inventarioCafe)
    {
    	int nuevoCodigo = ListaDetalledeFactura.Count + 1;
    	int cantidad = 1;
    	//string ValorPago = "";
        
    	DetalledeFactura detalledeFactura = new DetalledeFactura(nuevoCodigo, 1, inventarioCafe);
    	ListaDetalledeFactura.Add(detalledeFactura);
    	
    	//Convert.ToDouble(ValorPago);
    	
    	Subtotal += cantidad * inventarioCafe.Precio;
    	Isv = Subtotal * 0.15;
    	Total = Subtotal + Isv;
    	//Cambio = Total - Convert.ToDouble(ValorPago); // Convertir a Double ValorPago
    }
}