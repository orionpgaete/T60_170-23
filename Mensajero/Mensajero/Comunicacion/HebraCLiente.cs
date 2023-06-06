using MensajeroModel;
using ServidorSocketUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajero.Comunicacion
{
    public class HebraCLiente
    {
        private static IMensajesDAL mensajesDAL = MensajesDALArchivos.GetInstancia();

        private ClienteCom clienteCom;

        public HebraCLiente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }

        public void Ejecutar()
        {
            //aca adentro traigo el metodo que atiende al cliente
            clienteCom.Escribir("Ingresar nombre: ");
            string nombre = clienteCom.Leer();
            clienteCom.Escribir("Ingrese texto");
            string texto = clienteCom.Leer();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "TCP"
            };
            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
            }

            clienteCom.Desconectar();
        }
    }
}
