using ServidorSocketUtil;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Socket
{
    public class Program
    {
        static void GenerarComunicacion(ClienteCom clienteCom)
        {
            bool terminar = false;
            while (!terminar)
            {
                string mensaje = clienteCom.Leer();
                if (mensaje != null)
                {
                    Console.WriteLine("Cli: {0}", mensaje);
                    if (mensaje.ToLower() == "chao")
                    {
                        terminar = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese respuesta: ");
                        mensaje = Console.ReadLine().Trim();
                        clienteCom.Escribir(mensaje);
                        if (mensaje.ToLower() == "chao")
                        {
                            terminar = true;
                        }
                    }
                }
                if (terminar)
                {
                    clienteCom.Desconectar();
                }
            }
        }
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("Iniciando servidor en puerto {0}", puerto);
            ServerSocket serversocket = new ServerSocket(puerto);
            if (serversocket.Iniciar())
            {
                while (true)
                {
                    Console.WriteLine("Esperando cliente...");
                    Socket socket = serversocket.ObtenerCliente();
                    Console.WriteLine("Ciente recibido");
                    ClienteCom clientecom = new ClienteCom(socket);
                    GenerarComunicacion(clientecom);
                }
            }
            else
            {
                Console.WriteLine("error a comunicarse con servidor {0}", puerto);
            }
        }
    }
}
