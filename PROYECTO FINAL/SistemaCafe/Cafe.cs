public class Cafe : Menu {
	
	public int NoOrden { get; set; }
	
	public Cafe (string nombre, string tipo, double precio, int noOrden) {
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}

}