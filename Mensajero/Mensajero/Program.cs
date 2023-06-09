﻿using Mensajero.Comunicacion;
using MensajeroModel;
using ServidorSocketUtil;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mensajero
{
    class Program
    {
        private static IMensajesDAL mensajesDAL = MensajesDALArchivos.GetInstancia();
        static bool Menu()
        {
            bool contia = true;
            Console.WriteLine("\n ¿Que quiere hacer?");
            Console.WriteLine(" 1. Ingresar \n 2. Mostrar \n 0. Salir ");
            switch (Console.ReadLine().Trim())
            {
                case "1": Ingresar();
                    break;
                case "2": Mostrar();
                    break;
                case "0": contia = false;
                    break;
                default: Console.WriteLine("Ingrese de nuevo");
                    break;
            }
            return contia;
        }

        static void IniciarServidor()
        {
           
        }
        static void Main(string[] args)
        {

            //1. Iniciar servidor socket en el puerto 3000
            //2. el puerto tiene que ser configurable App.config
            //3. cuando reciba un cliente, tiene que solicitar nombre, texto y agregar un nuev mensaje con el tipo TCP
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.Start();
            //IniciarServidor();
            //1. Como atender mas de un cliente a la vez?
            //2. Como evito que dos clientes ingresen a archivo a la vez???
            //3. COMO EVITAR EL bloqueo mutuo????

            while (Menu()) ;
            
        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese nombre : ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese texto : ");
            string texto = Console.ReadLine().Trim();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "Aplicacion"
            };
            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
            }
                 
        }

        static void Mostrar()
        {
            List<Mensaje> mensajes = null;
            lock (mensajesDAL)
            {
                mensajes = mensajesDAL.ObtenerMensajes();
            }            
            foreach(Mensaje men in  mensajes)
            {
                Console.Write(men.ToString());
            }

        }
    }
}
