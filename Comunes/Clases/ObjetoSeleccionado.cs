﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Comunes.Clases
{
    public class ObjetoSeleccionado
    {
        static object vObjeto;

        public static object ojeto
        {
            get
            {
                return vObjeto;
            }
            set
            {
                vObjeto = value;
            }
        }
    }
}