﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013201694
{
    public class Empleados
    {
        string EmpleadoID { get; set; }
        public Empleados(string empleadosid)
        {
            EmpleadoID = empleadosid;
        }
        public Empleados() { }
    }
}
