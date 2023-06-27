using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class BebidasDALObjetos : IBebidasDAL
    {
        public List<Bebida> ObtenerBebidas()
        {
            return new List<Bebida>()
            {
                new Bebida()
                {
                    Nombre = "Te Verde",
                    Codigo = "FP-01"
                },
                new Bebida()
                {
                    Nombre = "Cafe del dia",
                    Codigo = "CF-01"
                },
                new Bebida()
                {
                    Nombre = "Te Chai",
                    Codigo = "TE-01"
                },
                new Bebida()
                {
                    Nombre = "Te del dia",
                    Codigo = "TE-02"
                }
            };
        }
    }
}
