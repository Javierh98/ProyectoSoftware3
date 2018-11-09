using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Comunes.Filtros
{
    public class Filtro
    {
        #region Declaración de Variables
        private string vNombreCampo = string.Empty;
        private string vOperador = string.Empty;
        private object vValor = new object();
        private string vTipoDato = string.Empty;
        #endregion

        #region Declaración de Constructores

        public Filtro()
        {
        }

        public Filtro(string NombreCampo, string Operador, string Valor)
        {
            this.vNombreCampo = NombreCampo;
            this.vOperador = Operador;
            this.vValor = Valor;

        }

        public Filtro(string NombreCampo, string Operador, int Valor)
        {
            this.vNombreCampo = NombreCampo;
            this.vOperador = Operador;
            this.vValor = Valor;
        }


        public Filtro(string NombreCampo, string Operador, decimal Valor)
        {
            this.vNombreCampo = NombreCampo;
            this.vOperador = Operador;
            this.vValor = Valor;

        }


        public Filtro(string NombreCampo, string Operador, DateTime Valor)
        {
            this.vNombreCampo = NombreCampo;
            this.vOperador = Operador;
            this.vValor = Valor;

        }


        #endregion

        #region Declaración de Propiedades

        public string NombreCampo
        {
            get
            {
                return vNombreCampo;
            }
            set
            {
                vNombreCampo = value;
            }
        }

        public string Operador
        {
            get
            {
                return vOperador;
            }
            set
            {
                vOperador = value;
            }
        }

        public object Valor
        {
            get
            {
                return vValor;
            }
            set
            {
                vValor = value;
            }
        }

        public string TipoDato
        {
            get
            {
                return vTipoDato;
            }
            set
            {
                vTipoDato = value;
            }
        }

        #endregion

        #region Delcaracion de Métodos

        public FiltroWhere CrearWhere(List<Filtro> pParametros)
        {
            List<SqlParameter> vParametros = new List<SqlParameter>();
            FiltroWhere vFiltroWhere = new FiltroWhere();
            string vWhere = string.Empty;
            string vQuery = string.Empty;
            try
            {
                if (pParametros != null && pParametros.Count != 0)
                {
                    foreach (Filtro vFiltro in pParametros)
                    {

                        if (vFiltro.Operador.Trim() != string.Empty)
                        {
                            if (vQuery.Length != 0)
                            {
                                vQuery += " " + "AND ";
                            }

                            if (vFiltro.Valor.GetType().ToString().Equals("System.Int16") ||
                                vFiltro.Valor.GetType().ToString().Equals("System.Int32") ||
                                vFiltro.Valor.GetType().ToString().Equals("System.Int64") ||
                                vFiltro.Valor.GetType().ToString().Equals("System.Decimal"))
                            {

                                vQuery += vFiltro.NombreCampo + " " + vFiltro.Operador.ToUpper() + " @" + vFiltro.NombreCampo;
                                vParametros.Add(new SqlParameter("@" + vFiltro.NombreCampo, vFiltro.Valor));
                            }
                            else
                            {
                                switch (vFiltro.Operador.ToUpper())
                                {
                                    case "IN":
                                        if (vFiltro.Valor.ToString().IndexOf("(") >= 0 && vFiltro.Valor.ToString().IndexOf(")") >= 0)
                                        {
                                            vQuery += vFiltro.NombreCampo + " IN  " + vFiltro.Valor.ToString();
                                        }
                                        else
                                        {
                                            vQuery += vFiltro.NombreCampo + " IN  " + "(" + vFiltro.Valor.ToString() + ")";
                                        }
                                        break;
                                    default:
                                        vQuery += vFiltro.NombreCampo + " " + vFiltro.Operador.ToUpper() + " @" + vFiltro.NombreCampo;
                                        vParametros.Add(new SqlParameter("@" + vFiltro.NombreCampo, vFiltro.Valor));

                                        break;
                                }

                            }
                        }

                        if (vWhere.Trim().Length != 0)
                        {
                            vWhere += "\n" + vQuery;
                        }
                        else
                        {
                            vWhere += " WHERE " + vQuery;
                        }
                        vFiltroWhere.Filtros = vParametros;
                        vFiltroWhere.Where = vWhere;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return vFiltroWhere;
        }

        #endregion
    }
}
