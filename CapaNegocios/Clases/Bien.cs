using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios.Clases
{
    public class Bien
    {
        #region Declaracion de vacriables

        CapaDatos.Conexion.Conexion vConexion;
        CapaDatos.Conexion.Transaccion vTransaccion;

        #endregion

        #region Declaracion de Constructor
        public Bien()
        {
        }
        #endregion

        #region Delcaracion de Metodo Seleccionar

        public DataTable Select(List<Comunes.Filtros.Filtro> pFiltros)
        {
            DataTable dtDatos = new DataTable();
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                dtDatos = vCapaDatos.Select(pFiltros, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
            return dtDatos;
        }

        public DataTable Select()
        {
            DataTable dtDatos = new DataTable();
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                dtDatos = vCapaDatos.Select(null, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
            return dtDatos;
        }

        #endregion

        #region Declaracion de Metodo Insertar

        public void Insert(Comunes.Estructuras.Bien pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                vCapaDatos.Insert(pDatos, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
        }

        public void Insert(List<Comunes.Estructuras.Bien> pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();
                foreach (Comunes.Estructuras.Bien vItem in pDatos)
                {
                    vCapaDatos.Insert(vItem, vConexiones.Conexiones, vTransaccion.Transacciones);
                }
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Metodo Actualizar

        public void Update(Comunes.Estructuras.Bien pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                vCapaDatos.Update(pDatos, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
        }

        public void Update(List<Comunes.Estructuras.Bien> pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();
                foreach (Comunes.Estructuras.Bien vItem in pDatos)
                {
                    vCapaDatos.Update(vItem, vConexiones.Conexiones, vTransaccion.Transacciones);
                }
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Metodo Eliminar

        public void Delete(Comunes.Estructuras.Bien pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                vCapaDatos.Delete(pDatos, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
        }

        public void Delete(List<Comunes.Estructuras.Bien> pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.Bien vCapaDatos = new CapaDatos.Clases.Bien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();
                foreach (Comunes.Estructuras.Bien vItem in pDatos)
                {
                    vCapaDatos.Delete(vItem, vConexiones.Conexiones, vTransaccion.Transacciones);
                }
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

    }
}
