using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public class UsuarioLista
    {
        public static List<Usuario> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.fullname = fila[0].ToString();
                u.username = fila[1].ToString();
                u.password = fila[2].ToString();
                u.userType = Convert.ToBoolean(fila[3].ToString());

                lista.Add(u);
            }
            return lista;
        }

        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update appuser set contrasena='{0}' where idUser='{1}';",
                nuevaContra, usuario);
            
            ConexionBD.ExecuteQuery(sql);
        }
    }
}