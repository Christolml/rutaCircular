using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rutaCircular
{
    class Base
    {
        public string nombre { get; set; }
        public  int minutos { get; set; }

        public Base Siguiente { get; set; }
        public Base Anterior { get; set; }

        public Base(string nombre, int minutos)
        {
            this.nombre = nombre;
            this.minutos = minutos;
        }

        public override string ToString()
        {

            string mostrar = "";
            mostrar = " Ruta: " + nombre + "\r\n Tiempo: " + minutos;

            return mostrar;
        }


    }
}
