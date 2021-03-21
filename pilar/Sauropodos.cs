using System;
public class Sauropodos:Dinosaurios
{
    public bool Cuadrupedo { get; set; }

    
     public void metodo() // -> Abstraccion
    {
        Console.WriteLine("Herbivoro, Dientes de cuchara, Gran Tamaño");
    }


    public void tamanio()
    {
        Descripcion();
    }

    private void Descripcion() // -> Encapsulamiento
    {
        Console.WriteLine("Longitud: 37,2 metros ");
        Console.WriteLine("Peso: 69 toneladas ");
    }

    public void informacion()
    {
        Console.WriteLine("Este ejemplar es la pieza clave para explicar el gigantismo en los titanosaurios de Patagonia. Los más de 180 huesos encontrados en excelente estado de preservación lo coronan como uno de los descubrimientos paleontológicos más relevantes.");
    }
}