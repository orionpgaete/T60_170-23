using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Persona
{
    public partial class Program
    {
        static IPersonasDAL personasDAL = new PersonasDALArchivo();
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

            Persona p = new Persona()
            {
                Nombre = nombre,
                Estatura = estatura,
                Peso = peso,
                Telefono = telefono
            };
            /* p.Nombre = nombre;
             p.Estatura = estatura;
             p.Peso = peso;
             p.Telefono = telefono;*/

            p.calcularImc();
            personasDAL.AgregarPersona(p);

            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Telefono: {0}", p.Telefono);
            Console.WriteLine("Estatura: {0}", p.Estatura);
            Console.WriteLine("Peso: {0}", p.Peso);
            Console.WriteLine("IMC: {0}", p.IMC.Texto);
        }

        static void MostrarPersona()
        {
            List<Persona> personas = personasDAL.ObtenerPersonas();
            for (int i=0; i < personas.Count(); i++)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0}: Nombre: {1} Peso: {2}", i, actual.Nombre.ToLower(), actual.Peso);            }
        }

        static void BuscarPersona()

        {
            Console.WriteLine("Ingrese nombre");
            List<Persona> filtradas = personasDAL
                        .FiltrarPersonas(Console.ReadLine().Trim());
            filtradas.ForEach(p => Console.WriteLine("Nombre: {0} Peso: {1}", p.Nombre, p.Peso));


        }
    }
}
