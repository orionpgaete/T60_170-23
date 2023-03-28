using Ejercicio_Persona.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Persona
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu()) ;
        }

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");

            switch (Console.ReadLine().Trim())
            {
                case "1": IngresarPersona();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Aprete el teclado bien, gil!!!");
                    break;
            }
            return continuar;
        }
        static void IngresarPersona()
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;
            bool esValido;

            Console.WriteLine(" Bienvenido al programa del IMC");
            
            do
            {
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(string.Empty));

            do
            {
                Console.WriteLine("Ingrese telefono");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese estatura");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese Peso");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);
            } while (!esValido);

            Persona p = new Persona();

            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Telefono: {0}", telefono);
            Console.WriteLine("Estatura: {0}", estatura);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("IMC: {0}", peso/(estatura*estatura));

            Console.ReadKey();


        }
    }
}
