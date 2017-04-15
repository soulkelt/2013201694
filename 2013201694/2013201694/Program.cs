using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013201694
{
    public class Program
    {
        static void Main(string[] args)
        {
            var usu1 = "Luis Zapata";
            var usu2 = "Carlos Torres";
            var usu3 = "Juan Quispe";
            var usu4 = "María Palacios";
            var usu5 = "Mario Lopez";
            var venta = new Venta();
            venta.agregarUsuario(usu1);
            venta.agregarUsuario(usu2);
            venta.agregarUsuario(usu3);
            venta.agregarUsuario(usu4);
            venta.agregarUsuario(usu5);
            var tipoViaje1 = "Normal";
            var tipoViaje2 = "Vip";
            var transporte = new Transporte();
            transporte.TipoViajeSet(tipoViaje1);
            transporte.TipoViajeSet(tipoViaje2);
            var cliente = new Cliente();
            var tipoviaje = new TipoViaje();
            var tipoLugar = new TipoLugar();
            var lugarViaje = new LugarViaje();
            var tipolugar1 = "Trujillo";
            var tipoLugar2 = "Loreto";
            lugarViaje.agregarTipoLugar(tipolugar1);
            lugarViaje.agregarTipoLugar(tipoLugar2);

            lugarViaje.agregarTipoLugar("");

            Console.WriteLine("Ventas\nCliente\t\tTipoViaje\tDestino\n" + usu1 + "\t" + tipoViaje1 + "\t\t" + tipolugar1 + "\n"
                   + usu2 + "\t" + tipoViaje1 + "\t\t" + tipolugar1 + "\n" + usu3 + "\t" + tipoViaje2 + "\t\t" + tipolugar1);
            Console.WriteLine("Encomiendas\nCliente\t\tDestino\n" + usu4 + "\t\t" + tipolugar1 + "\n"  + usu5 + "\t\t" + tipolugar1);
            Console.ReadLine();
        }
    }
}
