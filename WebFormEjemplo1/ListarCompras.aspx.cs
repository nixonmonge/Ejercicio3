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
    public partial class ListarCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ComprasDAL.ListarTodo();
            GridView1.DataBind();
        }
    }
}