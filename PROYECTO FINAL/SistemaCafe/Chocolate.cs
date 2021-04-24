public class Chocolate : Menu {
		
	public int NoOrden { get; set; }
	
	public Chocolate(string nombre, string tipo, double precio, int noOrden)
	{
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}
}