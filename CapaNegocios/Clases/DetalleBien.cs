using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios.Clases
{
    public class DetalleBien
    {
        #region Declaracion de vacriables

        CapaDatos.Conexion.Conexion vConexion;
        CapaDatos.Conexion.Transaccion vTransaccion;

        #endregion

        #region Declaracion de Constructor
        public DetalleBien()
        {
        }
        #endregion

        #region Delcaracion de Metodo Seleccionar

        public DataTable Select(List<Comunes.Filtros.Filtro> pFiltros)
        {
            DataTable dtDatos = new DataTable();
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
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
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
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

        public List<Comunes.Estructuras.DetalleBien> Select64()
        {
            DataTable dtDatos = new DataTable();
            List<Comunes.Estructuras.DetalleBien> vResultado = new List<Comunes.Estructuras.DetalleBien>();
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
            Comunes.Estructuras.DetalleBien vItem;
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                dtDatos = vCapaDatos.Select(null, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();

                foreach (DataRow vRow in dtDatos.Rows)
                {
                    vItem = new Comunes.Estructuras.DetalleBien() {
                        Nombre_Detalle_Bien = vRow["Nombre_Detalle_Bien"].ToString(),
                        Costo_Detalle_Bien = Convert.ToInt32(vRow["Costo_Detalle_Bien"].ToString()),
                        Avaluo_Detalle_Bien = vRow["Avaluo_Detalle_Bien"].ToString(),
                        Estado_Detalle_Bien = vRow["Estado_Detalle_Bien"].ToString(),
                        Ubicacion_Bien = vRow["Ubicacion_Bien"].ToString(),
                        Base64 = Convert.ToBase64String((byte[])vRow["Foto_Detalle_Bien"]) 
                    };
                    vResultado.Add(vItem);
                }
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
            return vResultado;
        }

        public DataTable Select_Tres()
        {
            DataTable dtDatos = new DataTable();
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                dtDatos = vCapaDatos.Select_Tres(null, vConexiones.Conexiones, vTransaccion.Transacciones);
                vTransaccion.Commit();
            }
            catch (Exception ex)
            {
                vTransaccion.Rollback();
                throw new Exception(ex.Message, ex);
            }
            return dtDatos;
        }

        public DataTable SelectSinArchivo()
        {
            DataTable dtDatos = new DataTable();
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();

                dtDatos = vCapaDatos.SelectsinArchivo(null, vConexiones.Conexiones, vTransaccion.Transacciones);
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

        public void Insert(Comunes.Estructuras.DetalleBien pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
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

        public void Insert(List<Comunes.Estructuras.DetalleBien> pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();
                foreach (Comunes.Estructuras.DetalleBien vItem in pDatos)
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

        public void Update(Comunes.Estructuras.DetalleBien pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
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

        public void Update(List<Comunes.Estructuras.DetalleBien> pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();
                foreach (Comunes.Estructuras.DetalleBien vItem in pDatos)
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

        public void Delete(Comunes.Estructuras.DetalleBien pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
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

        public void Delete(List<Comunes.Estructuras.DetalleBien> pDatos)
        {
            CapaDatos.Conexion.Conexion vConexiones = new CapaDatos.Conexion.Conexion();
            CapaDatos.Conexion.Transaccion vTransaccion = new CapaDatos.Conexion.Transaccion();
            CapaDatos.Clases.DetalleBien vCapaDatos = new CapaDatos.Clases.DetalleBien();
            try
            {
                vConexiones.AbrirConexion("BASEDATOS");
                vTransaccion = new CapaDatos.Conexion.Transaccion(vConexiones.Conexiones, "BASEDATOS");
                vTransaccion.BeginTransaction();
                foreach (Comunes.Estructuras.DetalleBien vItem in pDatos)
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
