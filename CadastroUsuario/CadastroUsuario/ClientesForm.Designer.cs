namespace CadastroUsuario.UI.Windows
{
    partial class ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNovo = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnSair = new Button();
            btnGravar = new Button();
            btnConfirmarAlterar = new Button();
            btnConfirmarExcluir = new Button();
            btnVoltar = new Button();
            panelConteudo = new Panel();
            panelFicha = new Panel();
            txbId = new TextBox();
            label1 = new Label();
            mtbTelefone = new MaskedTextBox();
            txbEmail = new TextBox();
            txbNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvLista = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelConteudo.SuspendLayout();
            panelFicha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 406);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 44);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnNovo);
            flowLayoutPanel1.Controls.Add(btnAlterar);
            flowLayoutPanel1.Controls.Add(btnExcluir);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Controls.Add(btnGravar);
            flowLayoutPanel1.Controls.Add(btnConfirmarAlterar);
            flowLayoutPanel1.Controls.Add(btnConfirmarExcluir);
            flowLayoutPanel1.Controls.Add(btnVoltar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 7, 0, 0);
            flowLayoutPanel1.Size = new Size(800, 44);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(13, 10);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(94, 10);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(175, 10);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(256, 10);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(337, 10);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnConfirmarAlterar
            // 
            btnConfirmarAlterar.Location = new Point(418, 10);
            btnConfirmarAlterar.Name = "btnConfirmarAlterar";
            btnConfirmarAlterar.Size = new Size(120, 23);
            btnConfirmarAlterar.TabIndex = 5;
            btnConfirmarAlterar.Text = "Confirmar alteração";
            btnConfirmarAlterar.UseVisualStyleBackColor = true;
            btnConfirmarAlterar.Click += btnConfirmarAlterar_Click;
            // 
            // btnConfirmarExcluir
            // 
            btnConfirmarExcluir.Location = new Point(544, 10);
            btnConfirmarExcluir.Name = "btnConfirmarExcluir";
            btnConfirmarExcluir.Size = new Size(120, 23);
            btnConfirmarExcluir.TabIndex = 6;
            btnConfirmarExcluir.Text = "Confirmar exclusão";
            btnConfirmarExcluir.UseVisualStyleBackColor = true;
            btnConfirmarExcluir.Click += btnConfirmarExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(670, 10);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(panelFicha);
            panelConteudo.Controls.Add(dgvLista);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(10);
            panelConteudo.Size = new Size(800, 406);
            panelConteudo.TabIndex = 1;
            // 
            // panelFicha
            // 
            panelFicha.Controls.Add(txbId);
            panelFicha.Controls.Add(label1);
            panelFicha.Controls.Add(mtbTelefone);
            panelFicha.Controls.Add(txbEmail);
            panelFicha.Controls.Add(txbNome);
            panelFicha.Controls.Add(label4);
            panelFicha.Controls.Add(label3);
            panelFicha.Controls.Add(label2);
            panelFicha.Location = new Point(27, 17);
            panelFicha.Name = "panelFicha";
            panelFicha.Size = new Size(385, 335);
            panelFicha.TabIndex = 1;
            // 
            // txbId
            // 
            txbId.Location = new Point(82, 14);
            txbId.Name = "txbId";
            txbId.Size = new Size(60, 23);
            txbId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 17);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 11;
            label1.Text = "Id";
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(82, 99);
            mtbTelefone.Mask = "(99)9999-9999";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(277, 23);
            mtbTelefone.TabIndex = 9;
            mtbTelefone.TextChanged += mtbTelefone_TextChanged;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(82, 70);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(277, 23);
            txbEmail.TabIndex = 8;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(82, 41);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(277, 23);
            txbNome.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 102);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // dgvLista
            // 
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.EnableHeadersVisualStyles = false;
            dgvLista.Location = new Point(418, 17);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersVisible = false;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(369, 335);
            dgvLista.TabIndex = 0;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelConteudo);
            Controls.Add(panel1);
            Name = "ClientesForm";
            Text = "Clientes";
            Load += ClientesForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            panelFicha.ResumeLayout(false);
            panelFicha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNovo;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnSair;
        private Button btnGravar;
        private Button btnConfirmarAlterar;
        private Button btnConfirmarExcluir;
        private Panel panelConteudo;
        private DataGridView dgvLista;
        private Panel panelFicha;
        private TextBox txbEmail;
        private TextBox txbNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnVoltar;
        private MaskedTextBox mtbTelefone;
        private Label label1;
        private TextBox txbId;
    }
}