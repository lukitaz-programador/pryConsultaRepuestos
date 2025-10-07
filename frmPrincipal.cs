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

            lstMarcaa.Items.Add("(P) Peugeot");
            lstMarcaa.Items.Add("(F) Fiat");
            lstMarcaa.Items.Add("(R) Renault");

            lstOrigenn.Items.Add("(N) Nacional");
            lstOrigenn.Items.Add("(I) Importado");
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
            if (mtbNumero.MaskFull)
            {
                txtDescripción.Enabled = true;
            }
            else
            {
                txtDescripción.Enabled = false;
            }

            numero = Convert.ToInt32(mtbNumero.Mask);
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
            if (mtbPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }

            string precioString = mtbPrecio.Text.Replace("€", "").Trim();

            if (decimal.TryParse(precioString, out decimal valor))
            {
                precio = valor;
            }
            else
            {
                precio = 0;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            carga = true;

            // Recorremos solo hasta la cantidad de datos cargados (indice)
            while (i < indice)
            {
                if (vecDatos[i] != null) // si hay algo en esa posición
                {
                    // .Split() → Sirve para "cortar" un string en partes usando un separador
                    // Ejemplo: "A,B,C".Split(',') → ["A", "B", "C"]
                    string[] vecVariables = vecDatos[i].Split(',');

                    // .Trim() → Saca espacios en blanco al inicio y final de un string
                    // Ejemplo: "  Hola  ".Trim() → "Hola"
                    string tercera = vecVariables[2].Trim();

                    if (tercera == numero.ToString())
                    {
                        MessageBox.Show("Error. Ese número de repuesto ya está ingresado.");
                        carga = false;
                        break; // salgo del bucle porque ya encontré duplicado
                    }
                }
                i++;
            }

            // Si no hubo error, guardamos el nuevo repuesto
            if (carga)
            {
                vecDatos[indice] = marca + ", " + origen + ", "
                                 + numero + ", " + descripcion + ", " + precio;
                indice++;

                lstMarca.SelectedIndex = -1;
                lstOrigen.SelectedIndex = -1;
                mtbNumero.Text = "";
                txtDescripción.Text = "";
                mtbPrecio.Text = "";
            }
        }

        private void lstMarcaa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marcaElegida;
            string origenElegido;

            marcaElegida = lstMarcaa.Text;
            origenElegido = lstOrigenn.Text;
            bool coincideMarca = true;
            bool coincideOrigen = true;

            int i = 0;

            while (i < indice)
            {
                if (vecDatos[i] != null) // si hay algo en esa posición
                {
                    // .Split() → Sirve para "cortar" un string en partes usando un separador
                    // Ejemplo: "A,B,C".Split(',') → ["A", "B", "C"]
                    string[] vecVariables = vecDatos[i].Split(',');

                    // .Trim() → Saca espacios en blanco al inicio y final de un string
                    // Ejemplo: "  Hola  ".Trim() → "Hola"
                    string primera = vecVariables[0].Trim();
                    string segunda = vecVariables[1].Trim();

                    if (primera != marcaElegida)
                    {
                        coincideMarca = false;
                    }
                    if (segunda!=origenElegido)
                    {
                        coincideOrigen = false;
                    }

                    if (coincideMarca==true && coincideOrigen==true)
                    {
                        lstRepuestos.Items.Add(vecDatos[indice]);
                    }
                }
                i++;
            }
        }

        private void lstOrigenn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
