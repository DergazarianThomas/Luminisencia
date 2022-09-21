using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Trabajo_programacion
{
    public partial class Form1 : Form
    {

        Calculos Calculos = new Calculos();

        public Form1()
        {
            InitializeComponent();
        }

        


        private void btnIndK_Click(object sender, EventArgs e)
        {
            if (txtLargo.Text.Length == 0 || txtAncho.Text.Length == 0 || txtAltura.Text.Length == 0)
            {
                lblIndK.Text = "No deje ningun campo vacio";

            }
            else
            {
                lblIndK.Text = Calculos.IndiceK(txtLargo.Text, txtAncho.Text, txtAltura.Text);

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLargo.Text.Length == 0 || txtAncho.Text.Length == 0 || txtIlumSol.Text.Length == 0 || txtMant.Text.Length == 0 || txtUtiliz.Text.Length == 0)
            {
                lblFlujoLum.Text = "No deje ningun campo vacio";
            }
            else
            {
                lblFlujoLum.Text = Calculos.FlujoLuminoso(txtLargo.Text, txtAncho.Text, txtIlumSol.Text, txtMant.Text, txtUtiliz.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLargo.Text.Length == 0 || txtAncho.Text.Length == 0 || txtLumenes.Text.Length == 0 || txtMant.Text.Length == 0 || txtUtiliz.Text.Length == 0 || txtPotencia.Text.Length == 0)
            {
                lblLumOblg.Text = "No deje ningun campo vacio";
                lblIlum.Text = "No deje ningun campo vacio";
            }
            else
            {
                lblLumOblg.Text = Calculos.NumLamp(txtLumenes.Text);

                lblIlum.Text = Calculos.Iluminancia(txtPotencia.Text, txtLumenes.Text, txtMant.Text, txtUtiliz.Text, txtLargo.Text, txtAncho.Text);

                
                string[] pepe = Calculos.LampFinales(txtAncho.Text, txtLargo.Text, lblLumOblg.Text, txtPotencia.Text);
                lblLampAncho.Text = pepe[0];
                lblLampLargo.Text = pepe[1];
                lblSepLampLargo.Text = pepe[2];
                lblSepLampAncho.Text = pepe[3];
                lblSepParedL.Text = pepe[4];
                lblSepParedA.Text = pepe[5];
                lblLampTotal.Text = pepe[6];
                lblPotTotal.Text = pepe[7];

            }
                

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( ( !char.IsNumber(e.KeyChar) ) && (!char.IsControl(e.KeyChar) && (e.KeyChar != ',')) )
            {
                e.Handled = true;
            }

        }

    }

    
}
