public class CafeTender : Persona {
	
	public int CodigoCafeTender { get; set; }
	
	public CafeTender (string nombre, string apellido, string telefono, int codigoCafeTender)
	
	{
		
		Nombre = nombre;
		Apellido = apellido;
		Telefono = telefono;
		CodigoCafeTender = codigoCafeTender;
		
	}

}