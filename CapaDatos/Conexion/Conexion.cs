using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Conexion
{
    public class Conexion
    {
        #region Declaracion de Atributos
        SqlConnection vConnection;
        #endregion

        #region Declaracion de Constructor
        public Conexion()
        {

        }

        #endregion

        #region Declaracion de Propiedades
        public SqlConnection Conexiones
        {
            get
            {
                return vConnection;
            }
        }
        #endregion

        #region Declaracion de Metodos

        public void AbrirConexion(string pConexion)
        {
            string vInstancia = string.Empty;
            try
            {
                vInstancia = ConfigurationManager.ConnectionStrings[pConexion].ConnectionString;
                vConnection = new SqlConnection(vInstancia);
                vConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void CerrarConexion(SqlConnection pConexion)
        {
            string vInstancia = string.Empty;
            try
            {
                pConexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion
    }
}
