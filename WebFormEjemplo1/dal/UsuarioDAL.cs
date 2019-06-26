﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormEjemplo1.base2;
using WebFormEjemplo1.servicio;

namespace WebFormEjemplo1.dal
{
    public class UsuarioDAL
    {
        public static Usuario Validar(Usuario antiguo)
        {
            var nuevo=new Usuario();
            using(var grupo=new Model1())
            {
                nuevo=grupo.usuarios
                    .Where( u => u.NombreCuenta==antiguo.NombreCuenta)
                    .FirstOrDefault(); // Si no esta el usuario, devuelve un nulo
                    //.First();  // Si no esta el usuario, se va a generar un error
            }
            if (nuevo!=null && Util.Base64Encode(Util.Encriptar(antiguo.Clave))!=nuevo.Clave)
            {
                nuevo=null;
            }
            return nuevo;
        }
        public static List<Usuario> ListarTodo()
        {
            var resultado=new List<Usuario>();
            using (var grupo = new Model1())
            {
                resultado=grupo.usuarios
                    .OrderBy( u => u.NombreCompleto )
                    .ToList();
            }
            return resultado;
        }

    }
}