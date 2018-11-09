using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Filtros
{
    public class FiltroWhere
    {
        #region Delcaracion de Atributos
        List<SqlParameter> vFiltros;
        string vWhere;
        #endregion

        #region Declaracion de Constructor
        public FiltroWhere()
        {
            vFiltros = new List<SqlParameter>();
            vWhere = string.Empty;
        }
        #endregion

        #region Declcaracion de Propiedades
        public List<SqlParameter> Filtros
        {
            get
            {
                return vFiltros;
            }
            set
            {
                vFiltros = value;
            }
        }

        public string Where
        {
            get
            {
                return vWhere;
            }
            set
            {
                vWhere = value;
            }
        }
        #endregion
    }
}
