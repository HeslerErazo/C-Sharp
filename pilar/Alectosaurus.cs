public class Alectrosaurus:Tiranosauridos
{
     public  bool  Teropodo { get; set; }


    public Alectrosaurus() // -> Polimorfismo
    {
        Teropodo = true;
    }

    public Alectrosaurus(bool teropodo) // -> Polimorfismo
    {
        Teropodo = teropodo;
    }

}