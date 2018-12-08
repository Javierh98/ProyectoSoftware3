using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Propiedades()
        {
            ViewBag.Message = "Your application goodies page.";
           
            return View();
        }

        public ActionResult Vehiculos()
        {
            ViewBag.Message = "Your application goodies page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Detalle_Propiedad()
        {
            ViewBag.Message = "Your application description page.";
            Comunes.Estructuras.DetalleBien vDetalleBien = new Comunes.Estructuras.DetalleBien();
            vDetalleBien = (Comunes.Estructuras.DetalleBien)Comunes.Clases.ObjetoSeleccionado.ojeto;
            vDetalleBien.Base64 = Convert.ToBase64String(vDetalleBien.Foto_Detalle_Bien);

            return View(vDetalleBien);
        }

        public void Detalle_Propiedad_Procesar(string valores)
        {
            CapaNegocios.Clases.DetalleBien vDetalle = new CapaNegocios.Clases.DetalleBien();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();

            vFiltro.Add(new Comunes.Filtros.Filtro("ID_Detalle_Bien", "=", Convert.ToInt32(valores)));
            Comunes.Clases.ObjetoSeleccionado.ojeto = ConvertirDetalle_Bien(vDetalle.Select(vFiltro));

        }

        public ActionResult Detalle_Vehiculo()
        {
            ViewBag.Message = "Your application description page.";
            Comunes.Estructuras.DetalleBien vDetalleBien = new Comunes.Estructuras.DetalleBien();
            vDetalleBien = (Comunes.Estructuras.DetalleBien)Comunes.Clases.ObjetoSeleccionado.ojeto;
            vDetalleBien.Base64 = Convert.ToBase64String(vDetalleBien.Foto_Detalle_Bien);

            return View(vDetalleBien);
        }

        public void Detalle_Vehiculo_Procesar(string valores)
        {
            CapaNegocios.Clases.DetalleBien vDetalle = new CapaNegocios.Clases.DetalleBien();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();

            vFiltro.Add(new Comunes.Filtros.Filtro("ID_Detalle_Bien", "=", Convert.ToInt32(valores)));
            Comunes.Clases.ObjetoSeleccionado.ojeto = ConvertirDetalle_Bien(vDetalle.Select(vFiltro));

        }

        private Comunes.Estructuras.DetalleBien ConvertirDetalle_Bien(DataTable pDatos)
        {
            Comunes.Estructuras.DetalleBien vDetalleBien = new Comunes.Estructuras.DetalleBien();
            foreach (DataRow vRow in pDatos.Rows)
            {
                vDetalleBien = new Comunes.Estructuras.DetalleBien()
                {
                    ID_Bien = Convert.ToInt32(vRow["ID_Bien"]),
                    ID_Detalle_Bien = Convert.ToInt32(vRow["ID_Detalle_Bien"]),
                    Nombre_Detalle_Bien = vRow["Nombre_Detalle_Bien"].ToString(),
                    Estado_Detalle_Bien = vRow["Estado_Detalle_Bien"].ToString(),
                    Avaluo_Detalle_Bien = Convert.ToString(vRow["Avaluo_Detalle_Bien"]),
                    Costo_Detalle_Bien = Convert.ToInt32(vRow["Costo_Detalle_Bien"]),
                    Ubicacion_Bien = vRow["Ubicacion_Bien"].ToString(),
                    Foto_Detalle_Bien = (byte[])vRow["Foto_Detalle_Bien"]
                };
            }
            return vDetalleBien;
        }
    }
}
