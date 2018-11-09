using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Bien
    {

        #region Declaracion de atributos

        private int vID_Bien;
        private string vDescripcion_Bien;

        #endregion

        #region Declaracion de Constructor

        public Bien()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public string Descripcion_Bien
        {
            get
            {
                return vDescripcion_Bien;
            }
            set
            {
                vDescripcion_Bien = value;
            }
        }


        #endregion


    }
}
