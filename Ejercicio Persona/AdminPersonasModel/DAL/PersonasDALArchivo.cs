using Ejercicio_Persona;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALArchivo : IPersonasDAL
    {
        private static string archivo = "personas.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;

        public void AgregarPersona(Persona p)
        {
            //1. Crear el Streamwriter
            //2. Agreagr una linea del archivo
            //3. Crear el Streamwriter
            try
            {
                using (StreamWriter write = new StreamWriter(ruta, true))
                {
                    string texto = p.Nombre + ";" +
                                   p.Estatura + ";" +
                                   p.Telefono + ";" +
                                   p.Peso + ";";
                    write.WriteLine(texto);
                    write.Flush();
                }
            }catch (Exception ex) { 
                Console.WriteLine("Error¡¡¡¡al escribir el archivo "+ ex.Message);
            }
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            return ObtenerPersonas().FindAll(p => p.Nombre == nombre);
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            using (StreamReader reader = new StreamReader(ruta))
            {
                string texto;
                do
                {
                    //leer desde el archivo hasta que no haya nada
                    texto = reader.ReadLine();
                    if (texto != null)
                    {
                        string[] textoArr = texto.Trim().Split(';');
                        string nombre = textoArr[0];
                        double estatura = Convert.ToDouble(textoArr[1]);
                        uint telefono = Convert.ToUInt32(textoArr[2]);
                        double peso = Convert.ToDouble(textoArr[3]);

                        //crear una persona
                        Persona p = new Persona()
                        {
                            Nombre = nombre,
                            Estatura = estatura,
                            Telefono = telefono,
                            Peso = peso
                        };
                        //calcular IMC*
                        p.calcularImc();

                        //agregar a la lista
                        personas.Add(p);
                    }
                    
                } while (texto != null);
            }
            return personas;

          }



    }
}
