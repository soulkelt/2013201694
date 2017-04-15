using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013201694
{
    public class Tripulacion : Empleados
    {
        TipoTripulacion _TipoTripulacion;
        string TripulacionDesc { get; set; }
        public Tripulacion(TipoTripulacion tipoTripulacion)
        {
            _TipoTripulacion = tipoTripulacion;
        }

        public Tripulacion(string empleadosid) : base(empleadosid) { }

    }
}
