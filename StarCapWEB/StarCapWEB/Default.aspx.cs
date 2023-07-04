using StarCapModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWEB
{
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// Este metodo se ejecuta cuando se carga el form
        /// - cuando es una peticion GET (!PostBack)
        /// - cuando es una peticion POST (PostBack)
        /// </summary>

        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidasDAL bebidasDAL = new BebidasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
                this.bebidaDdl.DataSource = bebidas;
                this.bebidaDdl.DataTextField = "Nombre";
                this.bebidaDdl.DataValueField = "Codigo";
                this.bebidaDdl.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtner los datos del formulario
            string nombre = this.nombretxt.Text.Trim();
            string rut = this.ruttxt.Text.Trim();
            //obtiene el valor del dropdown
            string bebidaValor = this.bebidaDdl.SelectedValue;
            //obtiene el valor del texto
            string bebidaTexto = this.bebidaDdl.SelectedItem.Text;
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedValue);

            List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDdl.SelectedItem.Value);

            //2. Construir el objeto de tipo cliente
            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut = rut,
                Nivel = nivel,
                BebidaFavorita = bebida
            };

            //3. Llamar al DAL
            clientesDAL.Agregar(cliente);
            //4. Mostrar mensaje de texto
            this.mensaje.Text = "Cliente Ingresado";
            Response.Redirect("VerClientes.aspx");
        }
    }
}