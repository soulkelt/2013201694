using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013201694
{
    public class LugarViaje
    {
        private TipoViaje _TipoViaje;
        public LugarViaje(TipoViaje tipoViaje)
        {
            _TipoViaje = tipoViaje;
        }
        public TipoViaje lugarViaje { get { return _TipoViaje; } }
    }
}
