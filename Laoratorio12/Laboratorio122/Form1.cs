using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class lab122 : Form
    {
        public lab122()
        {
            InitializeComponent();
        }
        Promedio promedio = new Promedio();
        private void calcular_Click(object sender, EventArgs e)
        {
            float cal1 = float.Parse(txtNota1.Text);
            float cal2 = float.Parse(txtNota2.Text);
            float cal3 = float.Parse(txtNota3.Text);

            float suma = promedio.SumaCalificaciones(cal1, cal2, cal3);
            float resPromedio = promedio.CalcularPromedio(suma);

            lblres.Text = "El promedio es: " + resPromedio.ToString();
        }

        private void res_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            lblres.Text = "Resultado:";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
