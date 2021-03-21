public class Tiranosaurio:Tiranosauridos // -> Herencia
{
    public  bool  Teropodo { get; set; }


    public Tiranosaurio() // -> Polimorfismo
    {
        Teropodo = true;
    }

    public Tiranosaurio(bool teropodo) // -> Polimorfismo
    {
        Teropodo = teropodo;
    }


}