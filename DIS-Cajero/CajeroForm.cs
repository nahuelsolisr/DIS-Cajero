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
    public partial class CajeroForm : Form
    {
        public CajeroForm()
        {
            InitializeComponent();
        }

        private void btn_consultarSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btn_extraccion_Click(object sender, EventArgs e)
        {
            Extraccion nuevaExtraccion = new Extraccion();
            nuevaExtraccion.ShowDialog();
        }
    }
}
