﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesanjeroModel
{
    public interface IMensajesDAL
    {
        void AgregarMensaje(Mensaje mensaje);
        List<Mensaje> ObtenerMensajes();
    }
}
