using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Conexion
{
    public class Transaccion
    {
        #region Delcaracion de Atributos

        SqlTransaction vTransaccion;
        SqlConnection vConexion;
        string vNombreConexion;

        #endregion

        #region Declaracion del Constructor
        public Transaccion(SqlConnection pConexion, string pNombreConexion)
        {
            vConexion = pConexion;
            vNombreConexion = pNombreConexion;
        }
        public Transaccion()
        {
        }
        #endregion

        #region Declaracion de Propiedades
        public SqlTransaction Transacciones
        {
            get
            {
                return vTransaccion;
            }
        }
        #endregion

        #region Declaracion de Metodos
        public void BeginTransaction()
        {
            try
            {
                vTransaccion = vConexion.BeginTransaction(vNombreConexion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Commit()
        {
            try
            {
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Rollback()
        {
            try
            {
                vTransaccion.Rollback();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion
    }
}
