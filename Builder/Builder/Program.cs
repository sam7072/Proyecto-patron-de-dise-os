using System;
using Builder.Constructores;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();

            Console.WriteLine("Auto Eonomico");
            //el auto economico 
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);


            //obtenemos el auto
            Producto auto1 = normal.ObtenProducto();

            auto1.MostrarAuto();

            Console.WriteLine("----------------------");

            Console.WriteLine("Auto Deportivo");
            //auto deportivo
            BuilderDeportivo deportivo = new BuilderDeportivo();
            miDirector.Construye(deportivo);


            //obtenemos el auto
            Producto auto2 = deportivo.ObtenProducto();

            auto2.MostrarAuto();

        }
    }
}
