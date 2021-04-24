public class Te : Menu {
	
	public int NoOrden { get; set; }
	
	public Te (string nombre, string tipo, double precio, int noOrden)
	{
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}
}