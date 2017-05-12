using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rutaCircular
{
    class Ruta
    {
        private Base Primero;
        private Base Ultimo;
        int contador = 0;


        public Ruta()
        {
            Primero = null;
            Ultimo = null;
        }

        public void agregarRuta1(Base nuevo)
        {
 
                if (Primero == null)
                {
                    Primero = nuevo;
                    Primero.Siguiente = nuevo;
                    Ultimo = Primero;
                    contador++;
                }
                else
                {
                    if (buscarInicio(nuevo.nombre) == false)     //cuando es false quiere decir que aun no existe el nombre de la ruta y lo deja agregar a la lista
                    {
                    Ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = Primero;
                    Ultimo = nuevo;
                    contador++;
                    }


                }


        }

        public void agregarEnInicio(Base nuevo)
        {
            if(buscarInicio(nuevo.nombre) == false)               // cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {
                Base Actual = Primero;
                Primero = nuevo;
                Primero.Siguiente = Actual;
                Ultimo.Siguiente = Primero;
                contador++;
            }

        }

        public Base buscar(string nombre)
        {
            Base mostrar = null;
            Base Actual = Primero;    //aqui indico que el el producto actual empieza con el primer elemento que tengo, me sirve para recorrer la lista
            bool encontrado = false;            //sirve para indicarme cuando el codigo coincida con el que busco

            if (Primero != null)   //con este me dice que la lista si contiene algo dentro
            {
                do
                {
                    if(Actual.nombre == nombre)
                    {
                        mostrar = Actual;
                        encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero && encontrado != true);
            }
            else
                MessageBox.Show("Error, lista vacia");

            return mostrar;
        }

        public void eliminar(string nombre)
        {
            Base Actual = Primero;    
            Base Anterior = null;
            bool encontrado = false;            //sirve para indicarme cuando el codigo coincida con el que busco

            if (Primero != null)   
            {
                do
                {
                    if (Actual.nombre == nombre)
                    {
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                            Ultimo.Siguiente = Primero;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = Primero;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero && encontrado != true);
            }
            else
                MessageBox.Show("Error, lista vacia");
        }

        public void insertarDespuesDe( Base nuevo, string nombre)
        {
            Base Actual = Primero;
            Base temporal = null;

            bool encontrado = false;

            if (buscarInicio(nuevo.nombre) == false)         //puedo agregar, no existe la ruta
            {

                if (Primero != null)
                {
                    do
                    {
                        temporal = Actual.Siguiente;

                        if (Actual.nombre == nombre)
                        {
                            Actual.Siguiente = nuevo;
                            nuevo.Siguiente = temporal;
                            encontrado = true;
                        }
                        else
                            Actual = Actual.Siguiente;
                    }
                    while (Actual != Primero && encontrado != true);
                }
                else
                    MessageBox.Show("Error, lista vacia");

            }

        }

        
        public string recorrido(string ruta, DateTime inicioMin, DateTime finMin)
        {
            string mostrar = "";

            Base primeroMostrar = buscar(ruta);
            Base actual = buscar(ruta);

            DateTime inicio = inicioMin;

            if (Primero != null)   //con este me dice que la lista si contiene algo dentro
            {

                do    //este es para los nombres de las rutas
                {
                    mostrar += "    " + primeroMostrar.nombre + "              ";
                    primeroMostrar = primeroMostrar.Siguiente;

                }
                while (primeroMostrar != buscar(ruta));
                mostrar += "\r\n";

                do           //este es para los calculos de tiempos
                {
                    mostrar += inicio.Hour.ToString("00") + ":" + inicio.Minute.ToString("00") + "           ";

                    actual = actual.Siguiente;
                    inicio = inicio.AddMinutes(actual.minutos);

                    if (actual.Siguiente == buscar(ruta).Siguiente)
                    {
                        mostrar += "\r\n";
                    }
                }
                while (inicio < finMin);
            }
            else
                mostrar = "La lista esta vacia";

         return mostrar;

        }

        /// <summary>
        /// Método con el cual nos sirve verificar si ya existe un código y 
        /// este método lo maneja en gran parte el form 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool buscarInicio(string nombre)
        {
            bool mostrar = false;
            Base Actual = Primero;
            bool encontrado = false;

            if (Primero != null)   //con este me dice que la lista si contiene algo dentro
            {
                do
                {
                    if (Actual.nombre == nombre)
                    {
                        mostrar = true;
                        encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero && encontrado != true);
            }
            else
                mostrar = false;

            return mostrar;
        }


        public string reporte()
        {
            string mostrar = "";
            Base Actual = Primero;

            if (Actual != null)
            {
                do
                {
                    mostrar += Actual.ToString() + "\r\n\r\n";
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero);
            }
            else
                mostrar = "La lista no contiene elementos disponibles";

            return mostrar;
        }

    }
}
