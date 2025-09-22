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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Guardamos las variables dentro del vector
            vecDatos[indice] = (marca + origen + numero + descripcion + precio);
        }
    }
}
