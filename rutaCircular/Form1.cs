using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rutaCircular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Ruta ruta = new Ruta();


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int minutos = int.Parse(txtMins.Text);

            bool agregado = ruta.buscarInicio(txtRuta.Text);
            Base basse = new Base(txtRuta.Text,minutos);
            ruta.agregarRuta1(basse);

            verificadorCodigo(agregado, basse);
        }


        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            bool agregado = ruta.buscarInicio(txtRuta.Text);
            Base basse = new Base(txtRuta.Text, Convert.ToInt32(txtMins.Text));
            ruta.agregarEnInicio(basse);

            verificadorCodigo(agregado, basse);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Base buscado = ruta.buscar(txtConsultaRuta.Text);
            if (buscado != null)
            {
                txtReporte.Text = buscado.ToString();
            }
            else
            {
                txtReporte.Text = "";
                MessageBox.Show("Error, ruta no encontrada");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool agregado = ruta.buscarInicio(txtConsultaRuta.Text);
            ruta.eliminar(txtConsultaRuta.Text);

            if (agregado == true)
            {
                txtReporte.Text = "";
                MessageBox.Show("Ruta eliminada");
            }
            else
            {
                MessageBox.Show("Esa ruta no existe");
                txtReporte.Text = "";
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool agregado = ruta.buscarInicio(txtRuta.Text);
            Base basse = new Base(txtRuta.Text, Convert.ToInt32(txtMins.Text));
            ruta.insertarDespuesDe(basse, txtInsertarRuta.Text);

            verificadorCodigo(agregado, basse);
        }


        private void verificadorCodigo(bool agregado, Base basse)
        {
            if (agregado == false)
            {
                MessageBox.Show("Ruta guardada");
                txtReporte.Text = basse.ToString();
            }
            else
            {
                MessageBox.Show("Esa ruta ya existe");
                txtReporte.Text = "";
            }
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = ruta.reporte();
        }


        private void btnListar_Click(object sender, EventArgs e)
        {

            DateTime mins = Convert.ToDateTime(txtRecorridoInicio.Text);
            DateTime fin = Convert.ToDateTime(txtRecorridoFin.Text);

            txtReporte.Text = ruta.recorrido(txtRecorridoRuta.Text, mins,fin);

        }

        private void dtmMins_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
