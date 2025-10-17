using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laoratorio12
{
    public partial class Form1 : Form
    {
        private Calculos calculos = new Calculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(txtSpeed.Text);
            int time = Convert.ToInt32(txtTime.Text);

            int res = calculos.DistanciaRecorrida(speed, time);

            lblShowRes.Text = "La distancia recorrida es: "+ res.ToString() + " km";
        }

        private void lblShowRes_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSpeed.Clear();
            txtTime.Clear();

            lblShowRes.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
