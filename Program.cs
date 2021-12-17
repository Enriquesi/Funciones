using System;

namespace Programa_funciones
{
    class programa
    {
        static void Main(string[] arg)
        {
  
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" PROGRAMA PARA GEOMETRIA ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir") ;
                string opcion = Console.ReadLine();
                if (opcion == "s")
                {
                    break;
                }

                if (opcion == "c")
                {
                    Console.WriteLine("Circulo");
                    Console.WriteLine(circulo);
                    Console.ReadKey();
                } 
                else if (opcion == "r")
                {
                    Console.WriteLine("Rectangulo");
                    Console.WriteLine(rectangulo);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("triángulo");
                    Console.WriteLine(triángulo);
                    Console.ReadKey();
                }

            }
        
             static void circulo (){
                double pi =3.14;
                Console.WriteLine("Ingrese Radio");
                double vradio = double.Parse(Console.ReadLine());
                Console.WriteLine("\n vradio=" + (Math.PI * Math.Pow(vradio,2)));
                Console.WriteLine("El resultado es : "+ vradio );
            }
             static  void  rectangulo (){
                Console.WriteLine("Ingrese la Base");
                double vbase = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Altura");
                double valtura = double.Parse(Console.ReadLine());
                double resultado = vbase * valtura;
                Console.WriteLine("El resultado es : "+ resultado ); 

            }
             static void triángulo(){
                Console.WriteLine("Ingrese la Base");
                double vbase = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Altura");
                double valtura = double.Parse(Console.ReadLine());
                double resultado = (vbase * valtura) / 2;
                Console.WriteLine("El resultado es : "+ resultado );

            }
        }
    }
}

     
