public class InventarioCafe  {
	
	public string Nombre { get; set; }
	public string Tipo { get; set; }
	public double Precio { get; set; }
	public int NoOrden { get; set; }
	
	public InventarioCafe (string nombre, string tipo, double precio, int noOrden)
	{
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}
	
}