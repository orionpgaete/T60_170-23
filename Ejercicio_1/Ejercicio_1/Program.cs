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
            string edadTx = Console.ReadLine().Trim();
           
            int edad = -1;

            bool esValido = Int32.TryParse(edadTx, out edad);

            if (!esValido)
            {
                Console.WriteLine("Ingrese bien la edad");
            }else
            {
                Console.WriteLine("Su nombre es {0} y la edad es {1}", nombre, edad);
            }






            // TRIM = '   32   ' => '32';
            // trimstart = '   32   ' => '32   ';
            //trimend = '   32   ' => '   32';

            //  Console.WriteLine("Su nombre es " + nombre + "la edad es " + edad);


            // Forma 1 tradiciona

            /* string num = "12";
             int num2 = int.Parse(num);   //12

             try
             {
                 string num = "12";
                 int num2 = Convert.ToInt32(num);   //12
             }
             catch (Exception e) { }

             string num = "12";
             int num2;

             bool esValido = int.TryParse(num, out num2);
            */



            Console.ReadKey();
        }
    }
}
