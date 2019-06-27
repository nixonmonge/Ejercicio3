using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;
using WebFormEjemplo1.dal;
using WebFormEjemplo1.servicio;

namespace WebFormEjemplo1.servicio
{
    public class ComprasServicio
    {
        public static Compras FactoryCompras(TextBox txtCompraId, TextBox txtProducto, TextBox txtCantidad,
            TextBox txtPrecioUnitario, Usuario usuarioSesion)
        {
            var compra = new Compras();
            compra.CompraId = Convert.ToInt32(txtCompraId.Text);
            compra.Producto = txtProducto.Text;
            compra.Cantidad = Convert.ToInt32(txtCantidad.Text);
            compra.PrecioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            compra.UsuarioID = usuarioSesion.UsuarioId;
            return compra;
        }
    }
}