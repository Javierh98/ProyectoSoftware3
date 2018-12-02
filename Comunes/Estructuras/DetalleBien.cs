using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class DetalleBien
    {

        #region Declaracion de atributos

        private int vID_Detalle_Bien;
        private string vNombre_Detalle_Bien;
        private int vCosto_Detalle_Bien;
        private string vAvaluo_Detalle_Bien;
        private string vEstado_Detalle_Bien;
        private string vUbicacion_Bien;
        private Byte[] vFoto_Detalle_Bien;
        private int vPosicion_Lista_Detalle_Bien;
        private int vID_Bien;
        private int vBase64;

        #endregion

        #region Declaracion de Constructor

        public DetalleBien()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int ID_Detalle_Bien
        {
            get
            {
                return vID_Detalle_Bien;
            }
            set
            {
                vID_Detalle_Bien = value;
            }
        }

        public string Nombre_Detalle_Bien
        {
            get
            {
                return vNombre_Detalle_Bien;
            }
            set
            {
                vNombre_Detalle_Bien = value;
            }
        }

        public int Costo_Detalle_Bien
        {
            get
            {
                return vCosto_Detalle_Bien;
            }
            set
            {
                vCosto_Detalle_Bien = value;
            }
        }

        public string Avaluo_Detalle_Bien
        {
            get
            {
                return vAvaluo_Detalle_Bien;
            }
            set
            {
                vAvaluo_Detalle_Bien = value;
            }
        }

        public string Estado_Detalle_Bien
        {
            get
            {
                return vEstado_Detalle_Bien;
            }
            set
            {
                vEstado_Detalle_Bien = value;
            }
        }

        public string Ubicacion_Bien
        {
            get
            {
                return vUbicacion_Bien;
            }
            set
            {
                vUbicacion_Bien = value;
            }
        }

        public Byte[] Foto_Detalle_Bien
        {
            get
            {
                return vFoto_Detalle_Bien;
            }
            set
            {
                vFoto_Detalle_Bien = value;
            }
        }

        public int Posicion_Lista_Detalle_Bien
        {
            get
            {
                return vPosicion_Lista_Detalle_Bien;
            }
            set
            {
                vPosicion_Lista_Detalle_Bien = value;
            }
        }

        public int ID_Bien
        {
            get
            {
                return vID_Bien;
            }
            set
            {
                vID_Bien = value;
            }
        }

        public int Base64
        {
            get
            {
                return vBase64;
            }
            set
            {
                vBase64 = value;
            }
        }

        #endregion


    }
}
