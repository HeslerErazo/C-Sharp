public class Patagotitan:Sauropodos
{
    public string Nombre { get; set; }


    public Patagotitan() // -> Polimorfismo
    {
        Cuadrupedo = true;
    }

    public Patagotitan(bool cuadrupedo) // -> Polimorfismo
    {
        Cuadrupedo = cuadrupedo;
    }
}