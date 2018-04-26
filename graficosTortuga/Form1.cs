using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficosTortuga
{
    public partial class Form1 : Form
    {
        Tortuga tortuga = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            tortuga.Pluma = false;
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            tortuga.Pluma = true;
        }

        private void btnGirarDerecha_Click(object sender, EventArgs e)
        {
            tortuga.GirarDerecha();
        }

        private void btnGirarIzquierda_Click(object sender, EventArgs e)
        {
            tortuga.GirarIzquierda();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            tortuga.Avanzar(Convert.ToInt32(txtEspacios.Text));
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            txtMatriz.Text = tortuga.Graficar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            tortuga = new Tortuga();
        }
    }
}
