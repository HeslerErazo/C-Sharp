using System;
using System.Collections.Generic;

public class DetalledeFactura {
	
	public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public InventarioCafe InventarioCafe { get; set; }
    
    public DetalledeFactura ( int codigo, int cantidad, InventarioCafe inventarioCafe)
    {
    	Codigo = codigo;
    	Cantidad = cantidad;
    	InventarioCafe = inventarioCafe; // Llamar a clase invetario cafe
    	Precio = inventarioCafe.Precio; // Llamar al precio inventario cafe
    	
    }	
}