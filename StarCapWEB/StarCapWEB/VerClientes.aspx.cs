using StarCapModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWEB
{
    public partial class VerClientes : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = clientesDAL.Obtener();
            this.grillaCliente.DataSource = clientes;
            this.grillaCliente.DataBind();
        }
    }
}