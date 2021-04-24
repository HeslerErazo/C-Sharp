public class Frios : Menu {
	
	public int NoOrden { get; set; }
	
	public Frios (string nombre, string tipo, double precio, int noOrden) {
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}
	
}