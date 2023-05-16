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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            int tarjeta = Convert.ToInt32(txt_Tarjeta.Text);
            int pin = Convert.ToInt32(txt_Pin.Text);

            if ((tarjeta == cliente1.Tarjeta && pin == cliente1.Pin) ||
                (tarjeta == cliente2.Tarjeta && pin == cliente2.Pin) ||
                (tarjeta == cliente3.Tarjeta && pin == cliente3.Pin))
            {
                CajeroForm cajeroForm = new CajeroForm();
                cajeroForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Por favor, intente nuevamente.");
            }
        }
      

        private bool VerificarCredenciales(int tarjeta, int pin)
        {
            return false;
        }
    }
}