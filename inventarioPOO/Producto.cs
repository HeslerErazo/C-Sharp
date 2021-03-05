public class Producto
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public int Existencia { get; set; }
    public float Entrada { get; set; }
    public string Dinero { get; set; }

    public Producto(string codigo, string descripcion, int existencia, float entrada, string dinero)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
        Entrada = entrada;
        Dinero = dinero;
    }

}