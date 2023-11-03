using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroUsuario.DB;
using CadastroUsuario.Models;

namespace CadastroUsuario.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            dgvLista.Visible = true;
            dgvLista.Dock = DockStyle.Fill;
            panelFicha.Visible = false;
            btnNovo.Visible = true;
            btnAlterar.Visible = true;
            btnExcluir.Visible = true;
            btnSair.Visible = true;
            btnGravar.Visible = false;
            btnConfirmarAlterar.Visible = false;
            btnConfirmarExcluir.Visible = false;
            btnVoltar.Visible = false;

            var db = new ClienteDb();
            dgvLista.DataSource = db.Listar();
            dgvLista.Columns["Id"].Width = 50;
        }

        private void ExibirFicha()
        {
            panelFicha.Visible = true;
            panelFicha.Dock = DockStyle.Fill;
            dgvLista.Visible = false;
            btnNovo.Visible = false;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnSair.Visible = false;
            btnGravar.Visible = true;
            btnConfirmarAlterar.Visible = false;
            btnConfirmarExcluir.Visible = false;
            btnVoltar.Visible = true;
        }

        private void LimparFicha()
        {
            txbId.Enabled = true;
            txbId.Clear();
            txbNome.Clear();
            txbEmail.Clear();
            mtbTelefone.Clear();

            txbId.Focus();
        }


        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ExibirFicha();
            LimparFicha();
            label1.Visible = false;
            txbId.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.Id = Convert.ToInt32(txbId.Text);
            cliente.Nome = txbNome.Text;
            cliente.Email = txbEmail.Text;
            cliente.Telefone = mtbTelefone.Text;

            var db = new ClienteDb();
            db.Incluir(cliente);

            ExibirGrid();

        }

        private void btnConfirmarExcluir_Click(object sender, EventArgs e)
        {
            var db = new ClienteDb();
            db.Excluir(Convert.ToInt32(txbId.Text));

            ExibirGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dgvLista.CurrentRow.DataBoundItem;

            txbId.Text = cliente.Id.ToString();
            txbNome.Text = cliente.Nome;
            txbEmail.Text = cliente.Email;
            mtbTelefone.Text = cliente.Telefone;

            ExibirFicha();

            label1.Visible = true;
            txbId.Visible = true;
            txbId.Enabled = false;
            btnGravar.Visible = false;
            btnConfirmarExcluir.Visible = false;
            btnConfirmarAlterar.Visible = true;
        }

        private void btnConfirmarAlterar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.Id = Convert.ToInt32(txbId.Text);
            cliente.Nome = txbNome.Text;
            cliente.Email = txbEmail.Text;
            cliente.Telefone = mtbTelefone.Text;

            var db = new ClienteDb();
            db.Alterar(cliente);

            ExibirGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dgvLista.CurrentRow.DataBoundItem;

            txbId.Text = cliente.Id.ToString();
            txbNome.Text = cliente.Nome;
            txbEmail.Text = cliente.Email;
            mtbTelefone.Text = cliente.Telefone;

            ExibirFicha();

            label1.Visible = true;
            txbId.Visible = true;
            txbId.Enabled = false;
            btnGravar.Visible = false;
            btnConfirmarExcluir.Visible = true;
            btnConfirmarAlterar.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtbTelefone_TextChanged(object sender, EventArgs e)
        {
            if ("9".Equals(mtbTelefone.Text.Substring(4, 1)))
            {
                mtbTelefone.Mask = "(99)99999-9999";
            }
            else
            {
                mtbTelefone.Mask = "(99)9999-9999";
            }
        }
    }
}
