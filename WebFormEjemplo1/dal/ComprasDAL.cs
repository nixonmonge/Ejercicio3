using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;
using WebFormEjemplo1.dal;
using WebFormEjemplo1.servicio;

namespace WebFormEjemplo1.dal
{
    public class ComprasDAL
    {
        public static void Insertar(Compras compra)
        {
            using (var grupo = new Model1())
            {
                grupo.Compras.Add(compra);
                grupo.SaveChanges();

            }


        }

        public static List<Compras> ListarTodo()
        {
            var resultado = new List<Compras>();
            using (var grupo = new Model1())
            {
                resultado = grupo.Compras.ToList();
            }
            return resultado;
        }
    }
}