using System;
using Figuras;
namespace ProgramaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int contador = 0;
            figurasap f = new figurasap();
            bool figuracorrecta = true;    
            do { 
           
            Console.WriteLine("Ingreso figura");
            figuracorrecta = f.calculadora();
            if (figuracorrecta) { 
                contador ++;
                Console.WriteLine("Se calculó la figura # "+ contador);
            }
            Console.WriteLine("Desea hacer los calculos de area y perimetro de una figura mas?: (Si/si o No)");
            respuesta = Console.ReadLine();
               } while (respuesta == "Si" || respuesta == "si");
            Console.WriteLine("Usted ha calculado: " + contador + " figuras,");
        }
    }
}