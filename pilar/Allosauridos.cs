using System;

public class Allosauridos:Dinosaurios
{
    public string Nombre { get; set; }

    public void metodo() // -> Abstraccion
    {
        Console.WriteLine("Velocidad, Mandibulas");
    }

    public void tamanio()
    {
        Descripcion();
    }

    private void Descripcion()  // -> Encapsulamiento
    {
        Console.WriteLine("Longitud: 9 - 11,5 metros");
        Console.WriteLine("Peso: 4 - 7 toneladas ");
    }
}