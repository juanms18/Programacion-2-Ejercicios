namespace Vistas
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string nombre;
            string nombreAComparar = "juan";

            nombre = this.textName.Text;

            if (nombre != nombreAComparar)
            {
                MessageBox.Show("ERRORRRRRRRRRRR", "probando error" ,MessageBoxButtons.OK );
            }
            else
            {
                MessageBox.Show($"Mi nombre es {nombre}", "Probando saludo", MessageBoxButtons.OKCancel);
            }
            
        }

        private void FrmMiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea Salir??", "mnesaje de salir", MessageBoxButtons.OKCancel) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }
    }
}