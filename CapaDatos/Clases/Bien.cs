using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Bien
    {
        #region Declaracion de Variables

        SqlCommand vcmd;

        #endregion

        #region Declaracion de Constructor

        public Bien()
        {
        }
        #endregion

        #region Declaracion de Seleccionar

        public DataTable Select(List<Comunes.Filtros.Filtro> pFiltros, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            DataTable dtDatos = new DataTable();
            Comunes.Filtros.Filtro vFiltros = new Comunes.Filtros.Filtro();
            Comunes.Filtros.FiltroWhere vFiltroWhere = new Comunes.Filtros.FiltroWhere();
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "SELECT ";
                vSQL += "ID_Bien ";
                vSQL += ",Descripcion_Bien ";
                vSQL += " FROM dbo.Bien";
                if (pFiltros != null)
                {
                    vFiltroWhere = vFiltros.CrearWhere(pFiltros);
                    vSQL += vFiltroWhere.Where;
                    vcmd = new SqlCommand(vSQL, pConexion);
                    foreach (SqlParameter vItem in vFiltroWhere.Filtros)
                    {
                        vcmd.Parameters.Add(vItem);
                    }
                    vcmd.Transaction = pTransaccion;
                }
                else
                {
                    vcmd = new SqlCommand(vSQL, pConexion);
                    vcmd.Transaction = pTransaccion;
                }
                dtDatos = vExecute.ExecuteDatatable(vcmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtDatos;
        }
        #endregion

        #region Declaración de Insertar
        public void Insert(Comunes.Estructuras.Bien pDatos, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "INSERT INTO dbo.Bien (ID_Bien, Descripcion_Bien) ";
                vSQL += "VALUES(@ID_Bien, @Descripcion_Bien)";

                vcmd = new SqlCommand(vSQL, pConexion);
                vcmd.Transaction = pTransaccion;
                vcmd.Parameters.Add("@ID_Bien", SqlDbType.Int).Value = pDatos.ID_Bien;
                vcmd.Parameters.Add("@Descripcion_Bien", SqlDbType.VarChar).Value = pDatos.Descripcion_Bien;

                vExecute.ExecuteNonQuery(vcmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Eliminar
        public void Delete(Comunes.Estructuras.Bien pDatos, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "DELETE FROM dbo.Bien ";
                vSQL += "WHERE ID_Bien = @ID_Bien";

                vcmd = new SqlCommand(vSQL, pConexion);
                vcmd.Transaction = pTransaccion;
                vcmd.Parameters.Add("@ID_Bien", SqlDbType.Int).Value = pDatos.ID_Bien;

                vExecute.ExecuteNonQuery(vcmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Actualizar

        public void Update(Comunes.Estructuras.Bien pDatos, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "UPDATE dbo.Bien ";
                vSQL += "SET Descripcion_Bien = @Descripcion_Bien ";
                vSQL += "WHERE ID_Bien = @ID_Bien ";

                vcmd = new SqlCommand(vSQL, pConexion);
                vcmd.Transaction = pTransaccion;
                vcmd.Parameters.Add("@ID_Bien", SqlDbType.Int).Value = pDatos.ID_Bien;
                vcmd.Parameters.Add("@Descripcion_Bien", SqlDbType.VarChar).Value = pDatos.Descripcion_Bien;

                vExecute.ExecuteNonQuery(vcmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

    }
}
