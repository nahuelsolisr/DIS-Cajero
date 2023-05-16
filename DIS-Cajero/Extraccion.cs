using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DIS_Cajero
{
    public partial class Extraccion : Form
    {
        public Extraccion()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text += "0";
        }


        private void btn_limpiar(object sender, EventArgs e)
        {
            string textoActual = txt_cantidad.Text;
            // Verifica si el texto tiene al menos un carácter
            if (!string.IsNullOrEmpty(textoActual))
            {
                // Elimina el último carácter del texto
                textoActual = textoActual.Remove(textoActual.Length - 1);

                // Asigna el nuevo texto al TextBox
                txt_cantidad.Text = textoActual;
            }
        }

        private void btn_cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {          
         
        }
    }
}
