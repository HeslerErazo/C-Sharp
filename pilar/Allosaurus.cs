public class Allosaurus:Allosauridos
{
    public bool Teropodo { get; set; }

    public Allosaurus() // -> Polimorfismo
    {
        Teropodo = true;
    }
    
    
    public Allosaurus(bool teropodo) // -> Polimorfismo
    {
        Teropodo = teropodo;
    }
}