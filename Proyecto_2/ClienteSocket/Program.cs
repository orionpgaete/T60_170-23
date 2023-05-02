using ClienteSocket.Comunicacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteSocket
{
    public class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            string servidor = ConfigurationManager.AppSettings["servidor"];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Conectando a Servidor {0} en puerto {1}", servidor, puerto);
            ClientesSocket clienteSocket = new ClientesSocket(servidor, puerto); 
            if (clienteSocket.Conectar())
            {
                Console.WriteLine("Conectado....");
                //recibir lo que envio el servidor
                string mensaje = clienteSocket.Leer();
                Console.WriteLine("Men : {0}", mensaje);
                string nombre = Console.ReadLine().Trim();
                clienteSocket.Escribir(nombre);
                Console.WriteLine("Men : {0}", nombre);
                clienteSocket.Desconectar();
            }
            else
            {
                Console.WriteLine("Error de Comunicacion");
            }
            Console.ReadKey();
        }
    }
}
