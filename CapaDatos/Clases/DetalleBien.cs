using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class DetalleBien
    {
        #region Declaracion de Variables

        SqlCommand vcmd;

        #endregion

        #region Declaracion de Constructor

        public DetalleBien()
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
                vSQL += "ID_Detalle_Bien ";
                vSQL += ",Nombre_Detalle_Bien ";
                vSQL += ",Costo_Detalle_Bien ";
                vSQL += ",Avaluo_Detalle_Bien ";
                vSQL += ",Estado_Detalle_Bien ";
                vSQL += ",Ubicacion_Bien ";
                vSQL += ",Foto_Detalle_Bien ";
                vSQL += ",Posicion_Lista_Detalle_Bien ";
                vSQL += ",ID_Bien ";
                vSQL += " FROM dbo.DetalleBien";
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

        public DataTable Select_Tres(List<Comunes.Filtros.Filtro> pFiltros, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            DataTable dtDatos = new DataTable();
            Comunes.Filtros.Filtro vFiltros = new Comunes.Filtros.Filtro();
            Comunes.Filtros.FiltroWhere vFiltroWhere = new Comunes.Filtros.FiltroWhere();
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "SELECT top 3 ";
                vSQL += "ID_Detalle_Bien ";
                vSQL += ",Nombre_Detalle_Bien ";
                vSQL += ",Costo_Detalle_Bien ";
                vSQL += ",Avaluo_Detalle_Bien ";
                vSQL += ",Estado_Detalle_Bien ";
                vSQL += ",Ubicacion_Bien ";
                vSQL += ",Foto_Detalle_Bien ";
                vSQL += ",Posicion_Lista_Detalle_Bien ";
                vSQL += ",ID_Bien ";
                vSQL += " FROM dbo.DetalleBien";
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
                    vSQL += " order by ID_Detalle_Bien desc";
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


        public DataTable Select_Propiedades(List<Comunes.Filtros.Filtro> pFiltros, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            DataTable dtDatos = new DataTable();
            Comunes.Filtros.Filtro vFiltros = new Comunes.Filtros.Filtro();
            Comunes.Filtros.FiltroWhere vFiltroWhere = new Comunes.Filtros.FiltroWhere();
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "SELECT ";
                vSQL += "ID_Detalle_Bien ";
                vSQL += ",Nombre_Detalle_Bien ";
                vSQL += ",Costo_Detalle_Bien ";
                vSQL += ",Avaluo_Detalle_Bien ";
                vSQL += ",Estado_Detalle_Bien ";
                vSQL += ",Ubicacion_Bien ";
                vSQL += ",Foto_Detalle_Bien ";
                vSQL += ",Posicion_Lista_Detalle_Bien ";
                vSQL += ",ID_Bien ";
                vSQL += " FROM dbo.DetalleBien";
               
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
                    vSQL += " Where ID_Bien = 1";
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


        public DataTable SelectsinArchivo(List<Comunes.Filtros.Filtro> pFiltros, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            DataTable dtDatos = new DataTable();
            Comunes.Filtros.Filtro vFiltros = new Comunes.Filtros.Filtro();
            Comunes.Filtros.FiltroWhere vFiltroWhere = new Comunes.Filtros.FiltroWhere();
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "SELECT ";
                vSQL += "ID_Detalle_Bien ";
                vSQL += ",Nombre_Detalle_Bien ";
                vSQL += ",Costo_Detalle_Bien ";
                vSQL += ",Avaluo_Detalle_Bien ";
                vSQL += ",Estado_Detalle_Bien ";
                vSQL += ",Ubicacion_Bien ";
                vSQL += ",Foto_Detalle_Bien ";
                vSQL += ",Posicion_Lista_Detalle_Bien ";
                vSQL += ",ID_Bien ";
                vSQL += " FROM dbo.DetalleBien";
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
        public void Insert(Comunes.Estructuras.DetalleBien pDatos, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "INSERT INTO dbo.DetalleBien (ID_Detalle_Bien, Nombre_Detalle_Bien, Costo_Detalle_Bien, Avaluo_Detalle_Bien, Estado_Detalle_Bien, Ubicacion_Bien, Foto_Detalle_Bien, Posicion_Lista_Detalle_Bien, ID_Bien) ";
                vSQL += "VALUES(@ID_Detalle_Bien, @Nombre_Detalle_Bien, @Costo_Detalle_Bien, @Avaluo_Detalle_Bien, @Estado_Detalle_Bien, @Ubicacion_Bien, @Foto_Detalle_Bien, @Posicion_Lista_Detalle_Bien, @ID_Bien)";

                vcmd = new SqlCommand(vSQL, pConexion);
                vcmd.Transaction = pTransaccion;
                vcmd.Parameters.Add("@ID_Detalle_Bien", SqlDbType.Int).Value = pDatos.ID_Detalle_Bien;
                vcmd.Parameters.Add("@Nombre_Detalle_Bien", SqlDbType.VarChar).Value = pDatos.Nombre_Detalle_Bien;
                vcmd.Parameters.Add("@Costo_Detalle_Bien", SqlDbType.Int).Value = pDatos.Costo_Detalle_Bien;
                vcmd.Parameters.Add("@Avaluo_Detalle_Bien", SqlDbType.VarChar).Value = pDatos.Avaluo_Detalle_Bien;
                vcmd.Parameters.Add("@Estado_Detalle_Bien", SqlDbType.VarChar).Value = pDatos.Estado_Detalle_Bien;
                vcmd.Parameters.Add("@Ubicacion_Bien", SqlDbType.VarChar).Value = pDatos.Ubicacion_Bien;
                vcmd.Parameters.Add("@Foto_Detalle_Bien", SqlDbType.VarBinary).Value = pDatos.Foto_Detalle_Bien;
                vcmd.Parameters.Add("@Posicion_Lista_Detalle_Bien", SqlDbType.Int).Value = pDatos.Posicion_Lista_Detalle_Bien;
                vcmd.Parameters.Add("@ID_Bien", SqlDbType.Int).Value = pDatos.ID_Bien;

                vExecute.ExecuteNonQuery(vcmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Eliminar
        public void Delete(Comunes.Estructuras.DetalleBien pDatos, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "DELETE FROM dbo.DetalleBien ";
                vSQL += "WHERE ID_Detalle_Bien = @ID_Detalle_Bien";

                vcmd = new SqlCommand(vSQL, pConexion);
                vcmd.Transaction = pTransaccion;
                vcmd.Parameters.Add("@ID_Detalle_Bien", SqlDbType.Int).Value = pDatos.ID_Detalle_Bien;

                vExecute.ExecuteNonQuery(vcmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Actualizar

        public void Update(Comunes.Estructuras.DetalleBien pDatos, SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            string vSQL = string.Empty;
            Conexion.Ejecucion vExecute = new Conexion.Ejecucion();
            try
            {
                vSQL += "UPDATE dbo.DetalleBien ";
                vSQL += "SET Nombre_Detalle_Bien = @Nombre_Detalle_Bien, Costo_Detalle_Bien = @Costo_Detalle_Bien, Avaluo_Detalle_Bien = @Avaluo_Detalle_Bien, Estado_Detalle_Bien = @Estado_Detalle_Bien, Ubicacion_Bien = @Ubicacion_Bien, Foto_Detalle_Bien = @Foto_Detalle_Bien, Posicion_Lista_Detalle_Bien = @Posicion_Lista_Detalle_Bien, ID_Bien = @ID_Bien ";
                vSQL += "WHERE ID_Detalle_Bien = @ID_Detalle_Bien ";

                vcmd = new SqlCommand(vSQL, pConexion);
                vcmd.Transaction = pTransaccion;
                vcmd.Parameters.Add("@ID_Detalle_Bien", SqlDbType.Int).Value = pDatos.ID_Detalle_Bien;
                vcmd.Parameters.Add("@Nombre_Detalle_Bien", SqlDbType.VarChar).Value = pDatos.Nombre_Detalle_Bien;
                vcmd.Parameters.Add("@Costo_Detalle_Bien", SqlDbType.Int).Value = pDatos.Costo_Detalle_Bien;
                vcmd.Parameters.Add("@Avaluo_Detalle_Bien", SqlDbType.VarChar).Value = pDatos.Avaluo_Detalle_Bien;
                vcmd.Parameters.Add("@Estado_Detalle_Bien", SqlDbType.VarChar).Value = pDatos.Estado_Detalle_Bien;
                vcmd.Parameters.Add("@Ubicacion_Bien", SqlDbType.VarChar).Value = pDatos.Ubicacion_Bien;
                vcmd.Parameters.Add("@Foto_Detalle_Bien", SqlDbType.VarBinary).Value = pDatos.Foto_Detalle_Bien;
                vcmd.Parameters.Add("@Posicion_Lista_Detalle_Bien", SqlDbType.Int).Value = pDatos.Posicion_Lista_Detalle_Bien;
                vcmd.Parameters.Add("@ID_Bien", SqlDbType.Int).Value = pDatos.ID_Bien;

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
