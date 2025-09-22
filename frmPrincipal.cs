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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Guardamos las variables dentro del vector
            vecDatos[indice] = (marca + origen + numero + descripcion + precio);
            indice++;

        }
    }
}
