using System;

public class Tiranosauridos:Dinosaurios  // - Herencia
{
    public string Nombre { get; set; }


     public void metodo() // -> Abstraccion
    {
        Console.WriteLine("Mordida Poderosa");
    }


    public void tamanio()
    {
        Descripcion();
    }

    private void Descripcion() // -> Encapsulamiento
    {
        Console.WriteLine("Longitud: 10 - 12,5 metros ");
        Console.WriteLine("Peso: 9,5 toneladas ");
    }

    public void Descripcion1()  // -> Abstraccion
    {
        Console.WriteLine("Longitud: 5 metros ");
        Console.WriteLine("Peso: 600 Kilogramos ");
    }


}