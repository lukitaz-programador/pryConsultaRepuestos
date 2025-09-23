namespace pryConsultaRepuestos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Definición de variables globales
        public static string[] vecDatos = new string[100];
        string marca;
        string origen;
        int numero;
        string descripcion;
        decimal precio;
        int indice = 0;
        bool carga;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lstMarca.Items.Add("(P) Peugeot");
            lstMarca.Items.Add("(F) Fiat");
            lstMarca.Items.Add("(R) Renault");

            lstOrigen.Items.Add("(N) Nacional");
            lstOrigen.Items.Add("(I) Importado");
        }
        private void lstMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstMarca.Text)
            {
                case "(P) Peugeot":
                    marca = "P";
                    break;

                case "(F) Fiat":
                    marca = "F";
                    break;

                case "(R) Renault":
                    marca = "R";
                    break;
            }

            if (marca != "")
            {
                lstOrigen.Enabled = true;
            }
            else
            {
                lstOrigen.Enabled = false;
            }
        }

        private void lstOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrigen.Text == "(N) Nacional")
            {
                origen = "N";
            }
            else if (lstOrigen.Text == "(I) Importado")
            {
                origen = "I";
            }

            if (lstOrigen.SelectedIndex != -1)
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }
        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(mtbNumero.Mask);

            if (mtbNumero.MaskFull)
            {
                txtDescripción.Enabled = true;
            }
            else
            {
                txtDescripción.Enabled = false;
            }
        }

        //Permite que solo los números se escriban en el TextBox

        // private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        // {

        //      if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        //      {
        //        e.Handled = true; // Cancela la pulsación de la tecla si no es un número o la tecla Backspace
        //      }

        // }

        private void txtDescripción_TextChanged(object sender, EventArgs e)
        {
            descripcion = txtDescripción.Text;

            if (txtDescripción.Text != "")
            {
                mtbPrecio.Enabled = true;
            }
            else
            {
                mtbPrecio.Enabled = false;
            }
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mtbPrecio_TextChanged(object sender, EventArgs e)
        {
            precio = Convert.ToInt32(mtbPrecio.Mask);

            if (mtbPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int i = 0;

            //Guardamos las variables dentro del vector
            while (i < 100)
            {
                //defino un array que me separe el vecDatos en 5
                string[] vecVariables = vecDatos[i].Split("; ");

                //armo una variable que me guarde el tercer valor de vecVariables
                string tercera = vecVariables[2];

                if (tercera == Convert.ToString(numero))
                {
                    MessageBox.Show("Error. Ese número de repuesto ya está ingresado.");
                    carga = false;
                }
            }

            if (carga)
            {
                vecDatos[indice] = (marca + ", " + origen + ", "
                    + numero + ", " + descripcion + ", " + precio);
                indice++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
