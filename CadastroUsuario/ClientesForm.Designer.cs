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
            panelConteudo = new Panel();
            dgvLista = new DataGridView();
            panelFicha = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panelFicha.SuspendLayout();
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
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(94, 10);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(175, 10);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(256, 10);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(337, 10);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarAlterar
            // 
            btnConfirmarAlterar.Location = new Point(418, 10);
            btnConfirmarAlterar.Name = "btnConfirmarAlterar";
            btnConfirmarAlterar.Size = new Size(75, 23);
            btnConfirmarAlterar.TabIndex = 5;
            btnConfirmarAlterar.Text = "Alterar";
            btnConfirmarAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarExcluir
            // 
            btnConfirmarExcluir.Location = new Point(499, 10);
            btnConfirmarExcluir.Name = "btnConfirmarExcluir";
            btnConfirmarExcluir.Size = new Size(75, 23);
            btnConfirmarExcluir.TabIndex = 6;
            btnConfirmarExcluir.Text = "Confirmar exclusão";
            btnConfirmarExcluir.UseVisualStyleBackColor = true;
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
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(418, 17);
            dgvLista.Name = "dgvLista";
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(369, 335);
            dgvLista.TabIndex = 0;
            // 
            // panelFicha
            // 
            panelFicha.Controls.Add(textBox4);
            panelFicha.Controls.Add(textBox3);
            panelFicha.Controls.Add(textBox2);
            panelFicha.Controls.Add(textBox1);
            panelFicha.Controls.Add(label4);
            panelFicha.Controls.Add(label3);
            panelFicha.Controls.Add(label2);
            panelFicha.Controls.Add(label1);
            panelFicha.Location = new Point(27, 17);
            panelFicha.Name = "panelFicha";
            panelFicha.Size = new Size(385, 335);
            panelFicha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
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
            // textBox1
            // 
            textBox1.Location = new Point(82, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 23);
            textBox4.TabIndex = 9;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelConteudo);
            Controls.Add(panel1);
            Name = "ClientesForm";
            Text = "ClientesForm";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panelFicha.ResumeLayout(false);
            panelFicha.PerformLayout();
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}