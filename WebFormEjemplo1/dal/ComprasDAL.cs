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
        public static void Eliminar(int compraId)
        {
            var compra = new Compras();
            using (var grupo = new Model1())
            {
                compra = grupo.Compras.FirstOrDefault(c => c.CompraId == compraId);
                grupo.Compras.Remove(compra); // marco el objeto para eliminar
                grupo.SaveChanges();
            }

        }
        public static void Modificar(Compras compra)
        {
            using (var grupo = new Model1())
            {
                var compraAntigua = grupo.Compras
                    .FirstOrDefault(c => c.CompraId == compra.CompraId); //Proxy
                compraAntigua.CompraId = compra.CompraId;
                compraAntigua.Cantidad = compra.Cantidad;
                compraAntigua.PrecioUnitario = compra.PrecioUnitario;
                compraAntigua.Producto = compra.Producto;

                grupo.SaveChanges();
            }

        }
        public static int Contar()
        {
            int total = 0;
            using (var grupo = new Model1())
            {
                total = grupo.Compras.Count();
            }
            return total;
        }


        public static List<Compras> Listar2()
        {
            var resultado = new List<Compras>();
            using (var grupo = new Model1())
            {

                resultado = grupo.Database.SqlQuery<Compras>("select * from compras").ToList();
            }
            return resultado;
        }

        public static List<Compras> ListarTodo()
        {
            var resultado = new List<Compras>();
            using (var grupo = new Model1())
            {
                // resultado = grupo.Compras.ToList();
                resultado = grupo.Compras.Include("Usuario").ToList();
            }
            return resultado;
        }
    }
}
