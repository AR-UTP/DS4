using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class lab123 : Form
    {
        public lab123()
        {
            InitializeComponent();
        }

        TrianguloCalc triangulo = new TrianguloCalc();

        private void lbl_Area_Click(object sender, EventArgs e)
        {

        }

        private void btn_semiP_Click(object sender, EventArgs e)
        {
            int ladoA = Convert.ToInt32(txt_ladoA.Text);
            int ladoB = Convert.ToInt32(txt_ladoB.Text);
            int ladoC = Convert.ToInt32(txt_ladoC.Text);

            TrianguloCalc triangulo = new TrianguloCalc();
            int semiP = triangulo.Semiperimetro(ladoA, ladoB, ladoC);
            txt_semiP.Text = Convert.ToString(semiP);
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            int ladoA = Convert.ToInt32(txt_ladoA.Text);
            int ladoB = Convert.ToInt32(txt_ladoB.Text);
            int ladoC = Convert.ToInt32(txt_ladoC.Text);

            double area = triangulo.Area(ladoA, ladoB, ladoC);
            txt_area.Text = Convert.ToString(area);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_ladoA.Clear();
            txt_ladoB.Clear();
            txt_ladoC.Clear();
            txt_semiP.Clear();
            txt_area.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
