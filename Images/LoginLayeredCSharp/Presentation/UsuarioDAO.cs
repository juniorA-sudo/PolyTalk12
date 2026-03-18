using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class UsuarioDAO
    {
        private string cadenaConexion;
        public UsuarioDAO(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

    }
}
