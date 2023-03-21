using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Ingrese nombre:");
            //esto es un Scanner
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            string edad = Console.ReadLine();
          //  Console.WriteLine("Su nombre es " + nombre + "la edad es " + edad);
            Console.WriteLine("Su nombre es {0} y la edad es {1}", nombre, edad);
 
            Console.ReadKey();
        }
    }
}
