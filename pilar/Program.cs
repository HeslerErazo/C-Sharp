using System;

namespace pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("DINOSAURIOS Y REPTILES MARINOS");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Tiranosauridos");
            Console.WriteLine("**************");
            Console.WriteLine("");

            Tiranosaurio tiranosaurio = new Tiranosaurio();
            tiranosaurio.Nombre = "Tiranosaurio Rex";
            tiranosaurio.Familia = "Tiranosauridae";
            tiranosaurio.Orden = "Saurischia";
            tiranosaurio.Teropodo = true;
            tiranosaurio.Periodo = "Cretacico Superior";
            tiranosaurio.metodo();
            tiranosaurio.tamanio();

            Console.WriteLine("Nombre: " + tiranosaurio.Nombre);
            Console.WriteLine("Familia: " + tiranosaurio.Familia);
            Console.WriteLine("Orden: " + tiranosaurio.Orden);
            Console.WriteLine("Suborden: Teropodo " + tiranosaurio.Teropodo);
            Console.WriteLine("Periodo: " + tiranosaurio.Periodo);

            Console.WriteLine("");

            Alectrosaurus alectrosaurus = new Alectrosaurus();
            alectrosaurus.Nombre = "Alectrosaurus Olseni";
            alectrosaurus.Familia = "Tyrannosauridea";
            alectrosaurus.Orden = "Saurischia";
            alectrosaurus.Teropodo = true;
            alectrosaurus.Periodo = "Cretacico Superior, Asia Central";
            alectrosaurus.Descripcion1();

            
            Console.WriteLine("Nombre: " + alectrosaurus.Nombre);
            Console.WriteLine("Familia: " + alectrosaurus.Familia);
            Console.WriteLine("Orden: " + alectrosaurus.Orden);
            Console.WriteLine("Suborden: Teropodo " + alectrosaurus.Teropodo);
            Console.WriteLine("Periodo: " + alectrosaurus.Periodo);


            Console.WriteLine("");
            Console.WriteLine("Allosauridos");
            Console.WriteLine("**************");
            Console.WriteLine("");

            Allosaurus allosaurus = new Allosaurus();
            allosaurus.Nombre = "Allosaurus Fragilis";
            allosaurus.Familia = "Allosauridae";
            allosaurus.Orden = "Saurischia";
            allosaurus.Teropodo = true;
            allosaurus.Periodo = "Jurasico Superior";
            allosaurus.metodo();
            allosaurus.tamanio();

            Console.WriteLine("Nombre: " + allosaurus.Nombre);
            Console.WriteLine("Familia: " + allosaurus.Familia);
            Console.WriteLine("Orden: " + allosaurus.Orden);
            Console.WriteLine("Suborden: Teropodo " + allosaurus.Teropodo);
            Console.WriteLine("Periodo: " + allosaurus.Periodo);

            Console.WriteLine("");
            Console.WriteLine("Reptiles Marinos");
            Console.WriteLine("****************");
            Console.WriteLine("");

            Liopleurodon liopleurodon = new Liopleurodon(true, "Agilidad, letalidad bajo el agua"); // - Poliformismo
            liopleurodon.Nombre = "Liopleurodon Ferox";
            liopleurodon.Familia = "Pliosauridae";
            liopleurodon.Orden = "Plesiosauria";
            liopleurodon.Pliosauridea = true;
            liopleurodon.Periodo = "Jurasico Medio";

            Console.WriteLine("Nombre: " + liopleurodon.Nombre);
            Console.WriteLine("Familia: " + liopleurodon.Familia);
            Console.WriteLine("Orden: " + liopleurodon.Orden);
            Console.WriteLine("Suborden: Pliosauridea " + liopleurodon.Pliosauridea);
            Console.WriteLine("Periodo: " + liopleurodon.Periodo);
            Console.WriteLine("Orden: " + liopleurodon.Pliosauridea);
            Console.WriteLine("Metodo: " + liopleurodon.Metodo);

            Console.WriteLine("");
            Console.WriteLine("Sauropodos");
            Console.WriteLine("**********");
            Console.WriteLine("");

            Patagotitan patagotitan = new Patagotitan();
            patagotitan.Nombre = "Patagotitan Mayorum";
            patagotitan.Familia = "Lognkosauria";
            patagotitan.Orden = "Saurischia";
            patagotitan.Cuadrupedo = true;
            patagotitan.Periodo = "Cretacico Superior, Patagonia Argentina";
            patagotitan.tamanio();
            patagotitan.metodo();
            patagotitan.informacion();

            Console.WriteLine("Nombre: " + patagotitan.Nombre);
            Console.WriteLine("Familia: " + patagotitan.Familia);
            Console.WriteLine("Orden: " + patagotitan.Orden);
            Console.WriteLine("Suborden: Cuadrupedo " + patagotitan.Cuadrupedo);
            Console.WriteLine("Periodo: " + patagotitan.Periodo);
        }
    }
}