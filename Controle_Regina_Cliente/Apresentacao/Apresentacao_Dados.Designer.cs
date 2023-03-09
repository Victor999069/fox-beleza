namespace Controle_Regina_Cliente.Apresentacao
{
    partial class Apresentacao_Dados
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
            this.components = new System.ComponentModel.Container();
            this.Dgv_Apresentacao_Dados = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prc_Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retornaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Apresentacao_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Apresentacao_Dados
            // 
            this.Dgv_Apresentacao_Dados.AllowUserToAddRows = false;
            this.Dgv_Apresentacao_Dados.AllowUserToDeleteRows = false;
            this.Dgv_Apresentacao_Dados.AllowUserToOrderColumns = true;
            this.Dgv_Apresentacao_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Apresentacao_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Nome_Cliente,
            this.Bairro_Cliente,
            this.Tel_Cliente,
            this.Nome_Servico,
            this.Prc_Servico});
            this.Dgv_Apresentacao_Dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Apresentacao_Dados.Location = new System.Drawing.Point(0, 24);
            this.Dgv_Apresentacao_Dados.Name = "Dgv_Apresentacao_Dados";
            this.Dgv_Apresentacao_Dados.ReadOnly = true;
            this.Dgv_Apresentacao_Dados.RowTemplate.Height = 25;
            this.Dgv_Apresentacao_Dados.Size = new System.Drawing.Size(800, 245);
            this.Dgv_Apresentacao_Dados.TabIndex = 0;
            this.Dgv_Apresentacao_Dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "Id Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.HeaderText = "Nome Cliente";
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.ReadOnly = true;
            // 
            // Bairro_Cliente
            // 
            this.Bairro_Cliente.HeaderText = "Bairro Cliente";
            this.Bairro_Cliente.Name = "Bairro_Cliente";
            this.Bairro_Cliente.ReadOnly = true;
            // 
            // Tel_Cliente
            // 
            this.Tel_Cliente.HeaderText = "Tel. Cliente";
            this.Tel_Cliente.Name = "Tel_Cliente";
            this.Tel_Cliente.ReadOnly = true;
            // 
            // Nome_Servico
            // 
            this.Nome_Servico.HeaderText = "Desc. Serviço";
            this.Nome_Servico.Name = "Nome_Servico";
            this.Nome_Servico.ReadOnly = true;
            // 
            // Prc_Servico
            // 
            this.Prc_Servico.HeaderText = "Prç. Serviço";
            this.Prc_Servico.Name = "Prc_Servico";
            this.Prc_Servico.ReadOnly = true;
            // 
            // cadastroClienteBindingSource
            // 
            this.cadastroClienteBindingSource.DataSource = typeof(Controle_Regina_Cliente.Cliente.Cadastro_Cliente);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modosToolStripMenuItem
            // 
            this.modosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retornaToolStripMenuItem});
            this.modosToolStripMenuItem.Name = "modosToolStripMenuItem";
            this.modosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.modosToolStripMenuItem.Text = "Modos";
            // 
            // retornaToolStripMenuItem
            // 
            this.retornaToolStripMenuItem.Name = "retornaToolStripMenuItem";
            this.retornaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.retornaToolStripMenuItem.Text = "Retorna";
            this.retornaToolStripMenuItem.Click += new System.EventHandler(this.retornaToolStripMenuItem_Click);
            // 
            // cadastroClienteBindingSource1
            // 
            this.cadastroClienteBindingSource1.DataSource = typeof(Controle_Regina_Cliente.Cliente.Cadastro_Cliente);
            // 
            // Apresentacao_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.Dgv_Apresentacao_Dados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Apresentacao_Dados";
            this.Text = "Dados Atendimentos";
            this.Load += new System.EventHandler(this.Apresentacao_Dados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Apresentacao_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Dgv_Apresentacao_Dados;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Nome_Cliente;
        private DataGridViewTextBoxColumn Bairro_Cliente;
        private DataGridViewTextBoxColumn Tel_Cliente;
        private DataGridViewTextBoxColumn Nome_Servico;
        private DataGridViewTextBoxColumn Prc_Servico;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modosToolStripMenuItem;
        private ToolStripMenuItem retornaToolStripMenuItem;
        private BindingSource cadastroClienteBindingSource;
        private BindingSource cadastroClienteBindingSource1;
    }
}