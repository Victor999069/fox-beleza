﻿namespace Controle_Regina_Cliente.Input_Dados
{
    partial class Registro_Prestacao
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
            this.Lbl_Input_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Input_Servico = new System.Windows.Forms.Label();
            this.Lbl_Input_Tel = new System.Windows.Forms.Label();
            this.Lbl_Input_Preco = new System.Windows.Forms.Label();
            this.Lbl_Input_Desconto = new System.Windows.Forms.Label();
            this.Txt_Registro_Desconto = new System.Windows.Forms.TextBox();
            this.Lbl_Prestacao_Inicial = new System.Windows.Forms.Label();
            this.conexaoClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cbm_Lista_Cliente = new System.Windows.Forms.ComboBox();
            this.cadastroClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retornarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Input_PrcFinal = new System.Windows.Forms.Label();
            this.Txt_Input_PrcFinal = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Cbm_Lista_Servico = new System.Windows.Forms.ComboBox();
            this.Mtb_Registro_Tel = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_Registro_Servico = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Input_Cliente
            // 
            this.Lbl_Input_Cliente.AutoSize = true;
            this.Lbl_Input_Cliente.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Cliente.Location = new System.Drawing.Point(3, 126);
            this.Lbl_Input_Cliente.Name = "Lbl_Input_Cliente";
            this.Lbl_Input_Cliente.Size = new System.Drawing.Size(103, 29);
            this.Lbl_Input_Cliente.TabIndex = 1;
            this.Lbl_Input_Cliente.Text = "Nome Cliente";
            // 
            // Lbl_Input_Servico
            // 
            this.Lbl_Input_Servico.AutoSize = true;
            this.Lbl_Input_Servico.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Servico.Location = new System.Drawing.Point(291, 126);
            this.Lbl_Input_Servico.Name = "Lbl_Input_Servico";
            this.Lbl_Input_Servico.Size = new System.Drawing.Size(122, 29);
            this.Lbl_Input_Servico.TabIndex = 3;
            this.Lbl_Input_Servico.Text = "Serviço Prestado";
            // 
            // Lbl_Input_Tel
            // 
            this.Lbl_Input_Tel.AutoSize = true;
            this.Lbl_Input_Tel.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Tel.Location = new System.Drawing.Point(2, 189);
            this.Lbl_Input_Tel.Name = "Lbl_Input_Tel";
            this.Lbl_Input_Tel.Size = new System.Drawing.Size(121, 29);
            this.Lbl_Input_Tel.TabIndex = 6;
            this.Lbl_Input_Tel.Text = "Telefone Cliente";
            // 
            // Lbl_Input_Preco
            // 
            this.Lbl_Input_Preco.AutoSize = true;
            this.Lbl_Input_Preco.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Preco.Location = new System.Drawing.Point(260, 189);
            this.Lbl_Input_Preco.Name = "Lbl_Input_Preco";
            this.Lbl_Input_Preco.Size = new System.Drawing.Size(50, 29);
            this.Lbl_Input_Preco.TabIndex = 8;
            this.Lbl_Input_Preco.Text = "Preço";
            // 
            // Lbl_Input_Desconto
            // 
            this.Lbl_Input_Desconto.AutoSize = true;
            this.Lbl_Input_Desconto.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Desconto.Location = new System.Drawing.Point(388, 189);
            this.Lbl_Input_Desconto.Name = "Lbl_Input_Desconto";
            this.Lbl_Input_Desconto.Size = new System.Drawing.Size(74, 29);
            this.Lbl_Input_Desconto.TabIndex = 10;
            this.Lbl_Input_Desconto.Text = "Desconto";
            this.Lbl_Input_Desconto.Click += new System.EventHandler(this.Lbl_Input_Desconto_Click);
            // 
            // Txt_Registro_Desconto
            // 
            this.Txt_Registro_Desconto.Location = new System.Drawing.Point(465, 189);
            this.Txt_Registro_Desconto.Name = "Txt_Registro_Desconto";
            this.Txt_Registro_Desconto.Size = new System.Drawing.Size(75, 23);
            this.Txt_Registro_Desconto.TabIndex = 9;
            this.Txt_Registro_Desconto.TextChanged += new System.EventHandler(this.Txt_Input_Desconto_LostFocus);
            // 
            // Lbl_Prestacao_Inicial
            // 
            this.Lbl_Prestacao_Inicial.AutoSize = true;
            this.Lbl_Prestacao_Inicial.Font = new System.Drawing.Font("Javanese Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Prestacao_Inicial.Location = new System.Drawing.Point(123, 13);
            this.Lbl_Prestacao_Inicial.Name = "Lbl_Prestacao_Inicial";
            this.Lbl_Prestacao_Inicial.Size = new System.Drawing.Size(365, 43);
            this.Lbl_Prestacao_Inicial.TabIndex = 12;
            this.Lbl_Prestacao_Inicial.Text = "Informe os dados do seu atendimento";
            // 
            // conexaoClienteBindingSource1
            // 
            this.conexaoClienteBindingSource1.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // conexaoClienteBindingSource
            // 
            this.conexaoClienteBindingSource.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // Cbm_Lista_Cliente
            // 
            this.Cbm_Lista_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbm_Lista_Cliente.FormattingEnabled = true;
            this.Cbm_Lista_Cliente.Location = new System.Drawing.Point(121, 126);
            this.Cbm_Lista_Cliente.Name = "Cbm_Lista_Cliente";
            this.Cbm_Lista_Cliente.Size = new System.Drawing.Size(138, 23);
            this.Cbm_Lista_Cliente.TabIndex = 16;
            this.Cbm_Lista_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cbm_Lista_Cliente_SelectedIndexChanged);
            // 
            // cadastroClienteBindingSource
            // 
            this.cadastroClienteBindingSource.DataSource = typeof(Controle_Regina_Cliente.Cliente.Cadastro_Cliente);
            // 
            // conexaoClienteBindingSource4
            // 
            this.conexaoClienteBindingSource4.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // conexaoClienteBindingSource2
            // 
            this.conexaoClienteBindingSource2.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // conexaoClienteBindingSource3
            // 
            this.conexaoClienteBindingSource3.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modosToolStripMenuItem
            // 
            this.modosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.retornarToolStripMenuItem});
            this.modosToolStripMenuItem.Name = "modosToolStripMenuItem";
            this.modosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.modosToolStripMenuItem.Text = "Modos";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // retornarToolStripMenuItem
            // 
            this.retornarToolStripMenuItem.Name = "retornarToolStripMenuItem";
            this.retornarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.retornarToolStripMenuItem.Text = "Retornar";
            this.retornarToolStripMenuItem.Click += new System.EventHandler(this.retornarToolStripMenuItem_Click);
            // 
            // Lbl_Input_PrcFinal
            // 
            this.Lbl_Input_PrcFinal.AutoSize = true;
            this.Lbl_Input_PrcFinal.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_PrcFinal.Location = new System.Drawing.Point(545, 189);
            this.Lbl_Input_PrcFinal.Name = "Lbl_Input_PrcFinal";
            this.Lbl_Input_PrcFinal.Size = new System.Drawing.Size(88, 29);
            this.Lbl_Input_PrcFinal.TabIndex = 19;
            this.Lbl_Input_PrcFinal.Text = "Preço Final";
            // 
            // Txt_Input_PrcFinal
            // 
            this.Txt_Input_PrcFinal.Location = new System.Drawing.Point(640, 189);
            this.Txt_Input_PrcFinal.Name = "Txt_Input_PrcFinal";
            this.Txt_Input_PrcFinal.Size = new System.Drawing.Size(75, 23);
            this.Txt_Input_PrcFinal.TabIndex = 18;
            this.Txt_Input_PrcFinal.TextChanged += new System.EventHandler(this.Txt_Input_PrcFinal_TextChanged);
            // 
            // Cbm_Lista_Servico
            // 
            this.Cbm_Lista_Servico.FormattingEnabled = true;
            this.Cbm_Lista_Servico.Location = new System.Drawing.Point(433, 126);
            this.Cbm_Lista_Servico.Name = "Cbm_Lista_Servico";
            this.Cbm_Lista_Servico.Size = new System.Drawing.Size(187, 23);
            this.Cbm_Lista_Servico.TabIndex = 20;
            this.Cbm_Lista_Servico.SelectedIndexChanged += new System.EventHandler(this.Cbm_Lista_Servico_SelectedIndexChanged);
            // 
            // Mtb_Registro_Tel
            // 
            this.Mtb_Registro_Tel.Location = new System.Drawing.Point(121, 189);
            this.Mtb_Registro_Tel.Mask = "(00) - 00000 - 0000";
            this.Mtb_Registro_Tel.Name = "Mtb_Registro_Tel";
            this.Mtb_Registro_Tel.Size = new System.Drawing.Size(138, 23);
            this.Mtb_Registro_Tel.TabIndex = 21;
            // 
            // Mtb_Registro_Servico
            // 
            this.Mtb_Registro_Servico.Location = new System.Drawing.Point(311, 190);
            this.Mtb_Registro_Servico.Name = "Mtb_Registro_Servico";
            this.Mtb_Registro_Servico.Size = new System.Drawing.Size(75, 23);
            this.Mtb_Registro_Servico.TabIndex = 22;
            this.Mtb_Registro_Servico.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtb_Registro_Servico_MaskInputRejected);
            // 
            // Registro_Prestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 306);
            this.Controls.Add(this.Mtb_Registro_Servico);
            this.Controls.Add(this.Mtb_Registro_Tel);
            this.Controls.Add(this.Cbm_Lista_Servico);
            this.Controls.Add(this.Lbl_Input_PrcFinal);
            this.Controls.Add(this.Txt_Input_PrcFinal);
            this.Controls.Add(this.Cbm_Lista_Cliente);
            this.Controls.Add(this.Lbl_Prestacao_Inicial);
            this.Controls.Add(this.Lbl_Input_Desconto);
            this.Controls.Add(this.Txt_Registro_Desconto);
            this.Controls.Add(this.Lbl_Input_Preco);
            this.Controls.Add(this.Lbl_Input_Tel);
            this.Controls.Add(this.Lbl_Input_Servico);
            this.Controls.Add(this.Lbl_Input_Cliente);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registro_Prestacao";
            this.Text = "Input_Dados";
            this.Load += new System.EventHandler(this.Registro_Prestacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Lbl_Input_Cliente;
        private Label Lbl_Input_Servico;
        private Label Lbl_Input_Tel;
        private Label Lbl_Input_Preco;
        private Label Lbl_Input_Desconto;
        private TextBox Txt_Registro_Desconto;
        private Label Lbl_Prestacao_Inicial;
        private BindingSource conexaoClienteBindingSource1;
        private BindingSource conexaoClienteBindingSource;
        private ComboBox Cbm_Lista_Cliente;
        private BindingSource conexaoClienteBindingSource2;
        private BindingSource conexaoClienteBindingSource4;
        private BindingSource conexaoClienteBindingSource3;
        private BindingSource cadastroClienteBindingSource;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modosToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem retornarToolStripMenuItem;
        private Label Lbl_Input_PrcFinal;
        private TextBox Txt_Input_PrcFinal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox Cbm_Lista_Servico;
        private MaskedTextBox Mtb_Registro_Tel;
        private MaskedTextBox Mtb_Registro_Servico;
    }
}