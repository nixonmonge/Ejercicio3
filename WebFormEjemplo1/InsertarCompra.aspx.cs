using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;
using WebFormEjemplo1.dal;
using WebFormEjemplo1.servicio;

namespace WebFormEjemplo1
{
    public partial class InsertarCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var usuarioSesion = (Usuario)Session["usuario"];
            var nuevaCompra = ComprasServicio.FactoryCompras(txtCompraId, txtProducto,txtCantidad,txtPrecioUnitario, usuarioSesion)
               ;ComprasDAL.Insertar(nuevaCompra);
            txtCompraId.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioUnitario.Text = "";
            txtUsuarioID.Text = "";


        }
    }
}