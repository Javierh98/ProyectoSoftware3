using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Conexion
{
   public class Ejecucion
    {
        #region Declaracion de Variables
        SqlDataAdapter vAdapter;
        #endregion

        #region Declaracion de Constructor
        public Ejecucion()
        {

        }

        #endregion

        #region Declaracion de Metodos
        public void ExecuteNonQuery(SqlCommand pCommand)
        {
            try
            {
                pCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataSet ExecuteDataSet(SqlCommand pCommand)
        {
            DataSet dsResultado = new DataSet();
            try
            {
                vAdapter = new SqlDataAdapter(pCommand);
                vAdapter.Fill(dsResultado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dsResultado;
        }

        public DataTable ExecuteDatatable(SqlCommand pCommand)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                vAdapter = new SqlDataAdapter(pCommand);
                vAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        #endregion
    }
}
