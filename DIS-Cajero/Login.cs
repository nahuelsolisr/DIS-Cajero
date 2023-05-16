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

            if (VerificarCredenciales(tarjeta, pin))
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
        private Dictionary<int, Cliente> usuarios = new Dictionary<int, Cliente>()
               {
                  { 1234567890, new Cliente(1234567890, 1234) },
                  { 1187643210, new Cliente(1187643210, 4321) }
               };
 
        private bool VerificarCredenciales(int tarjeta, int pin)
        {
            if (usuarios.ContainsKey(tarjeta))
            {
                Cliente cliente = usuarios[tarjeta];
                if (cliente.PIN == pin)
                {
                    return true;
                }
            }
            return false;
        }


    }
}