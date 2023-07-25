using CadastroUsuario.UI.Windows;

namespace CadastroUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ClientesForm();
            f.ShowDialog();
        }
    }
}