namespace Controle_Regina_Cliente.Cliente
{
    partial class Cadastro_Cliente
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
            this.Lbl_Text_Client = new System.Windows.Forms.Label();
            this.Txt_Cliente_Cadastro = new System.Windows.Forms.TextBox();
            this.Lbl_Nome_CLiente = new System.Windows.Forms.Label();
            this.Lbl_Tel_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Cliente_Bairro = new System.Windows.Forms.Label();
            this.Txt_Cliente_Bairro = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retornaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mtb_Cliente_Tel = new System.Windows.Forms.MaskedTextBox();
            this.Dtp_Cliente_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.Gbx_Cliente_Alergia = new System.Windows.Forms.GroupBox();
            this.Rbn_Cliente_Nenhuma = new System.Windows.Forms.RadioButton();
            this.Rbn_Cliente_Exantema = new System.Windows.Forms.RadioButton();
            this.Rbn_Cliente_Atopica = new System.Windows.Forms.RadioButton();
            this.Rbn_Cliente_Dermatite = new System.Windows.Forms.RadioButton();
            this.Rbn_Cliente_Urticaria = new System.Windows.Forms.RadioButton();
            this.Lbl_Cadastro_Nascimento = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Gbx_Cliente_Alergia.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Text_Client
            // 
            this.Lbl_Text_Client.AutoSize = true;
            this.Lbl_Text_Client.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Text_Client.Location = new System.Drawing.Point(193, 13);
            this.Lbl_Text_Client.Name = "Lbl_Text_Client";
            this.Lbl_Text_Client.Size = new System.Drawing.Size(330, 47);
            this.Lbl_Text_Client.TabIndex = 1;
            this.Lbl_Text_Client.Text = "Faça o Cadastro de Seu Cliente";
            this.Lbl_Text_Client.Click += new System.EventHandler(this.Lbl_Text_Client_Click);
            // 
            // Txt_Cliente_Cadastro
            // 
            this.Txt_Cliente_Cadastro.Location = new System.Drawing.Point(115, 97);
            this.Txt_Cliente_Cadastro.Name = "Txt_Cliente_Cadastro";
            this.Txt_Cliente_Cadastro.Size = new System.Drawing.Size(191, 23);
            this.Txt_Cliente_Cadastro.TabIndex = 1;
            // 
            // Lbl_Nome_CLiente
            // 
            this.Lbl_Nome_CLiente.AutoSize = true;
            this.Lbl_Nome_CLiente.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nome_CLiente.Location = new System.Drawing.Point(6, 97);
            this.Lbl_Nome_CLiente.Name = "Lbl_Nome_CLiente";
            this.Lbl_Nome_CLiente.Size = new System.Drawing.Size(108, 29);
            this.Lbl_Nome_CLiente.TabIndex = 3;
            this.Lbl_Nome_CLiente.Text = "Nome Cliente:";
            // 
            // Lbl_Tel_Cliente
            // 
            this.Lbl_Tel_Cliente.AutoSize = true;
            this.Lbl_Tel_Cliente.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Tel_Cliente.Location = new System.Drawing.Point(6, 162);
            this.Lbl_Tel_Cliente.Name = "Lbl_Tel_Cliente";
            this.Lbl_Tel_Cliente.Size = new System.Drawing.Size(126, 29);
            this.Lbl_Tel_Cliente.TabIndex = 5;
            this.Lbl_Tel_Cliente.Text = "Telefone Cliente:";
            // 
            // Lbl_Cliente_Bairro
            // 
            this.Lbl_Cliente_Bairro.AutoSize = true;
            this.Lbl_Cliente_Bairro.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cliente_Bairro.Location = new System.Drawing.Point(314, 97);
            this.Lbl_Cliente_Bairro.Name = "Lbl_Cliente_Bairro";
            this.Lbl_Cliente_Bairro.Size = new System.Drawing.Size(112, 29);
            this.Lbl_Cliente_Bairro.TabIndex = 9;
            this.Lbl_Cliente_Bairro.Text = "Bairro Cliente:";
            // 
            // Txt_Cliente_Bairro
            // 
            this.Txt_Cliente_Bairro.Location = new System.Drawing.Point(426, 97);
            this.Txt_Cliente_Bairro.Name = "Txt_Cliente_Bairro";
            this.Txt_Cliente_Bairro.Size = new System.Drawing.Size(191, 23);
            this.Txt_Cliente_Bairro.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modosToolStripMenuItem
            // 
            this.modosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.retornaToolStripMenuItem});
            this.modosToolStripMenuItem.Name = "modosToolStripMenuItem";
            this.modosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.modosToolStripMenuItem.Text = "Modos";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // retornaToolStripMenuItem
            // 
            this.retornaToolStripMenuItem.Name = "retornaToolStripMenuItem";
            this.retornaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.retornaToolStripMenuItem.Text = "Retorna";
            this.retornaToolStripMenuItem.Click += new System.EventHandler(this.retornaToolStripMenuItem_Click);
            // 
            // Mtb_Cliente_Tel
            // 
            this.Mtb_Cliente_Tel.Location = new System.Drawing.Point(129, 162);
            this.Mtb_Cliente_Tel.Mask = "(00) - 00000 - 0000";
            this.Mtb_Cliente_Tel.Name = "Mtb_Cliente_Tel";
            this.Mtb_Cliente_Tel.Size = new System.Drawing.Size(136, 23);
            this.Mtb_Cliente_Tel.TabIndex = 13;
            this.Mtb_Cliente_Tel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtb_Cliente_Tel_MaskInputRejected);
            // 
            // Dtp_Cliente_Nascimento
            // 
            this.Dtp_Cliente_Nascimento.Location = new System.Drawing.Point(426, 162);
            this.Dtp_Cliente_Nascimento.Name = "Dtp_Cliente_Nascimento";
            this.Dtp_Cliente_Nascimento.Size = new System.Drawing.Size(200, 23);
            this.Dtp_Cliente_Nascimento.TabIndex = 14;
            this.Dtp_Cliente_Nascimento.ValueChanged += new System.EventHandler(this.Dtp_Cliente_Nascimento_ValueChanged);
            // 
            // Gbx_Cliente_Alergia
            // 
            this.Gbx_Cliente_Alergia.Controls.Add(this.Rbn_Cliente_Nenhuma);
            this.Gbx_Cliente_Alergia.Controls.Add(this.Rbn_Cliente_Exantema);
            this.Gbx_Cliente_Alergia.Controls.Add(this.Rbn_Cliente_Atopica);
            this.Gbx_Cliente_Alergia.Controls.Add(this.Rbn_Cliente_Dermatite);
            this.Gbx_Cliente_Alergia.Controls.Add(this.Rbn_Cliente_Urticaria);
            this.Gbx_Cliente_Alergia.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gbx_Cliente_Alergia.Location = new System.Drawing.Point(12, 211);
            this.Gbx_Cliente_Alergia.Name = "Gbx_Cliente_Alergia";
            this.Gbx_Cliente_Alergia.Size = new System.Drawing.Size(243, 171);
            this.Gbx_Cliente_Alergia.TabIndex = 15;
            this.Gbx_Cliente_Alergia.TabStop = false;
            this.Gbx_Cliente_Alergia.Text = "Alergia";
            // 
            // Rbn_Cliente_Nenhuma
            // 
            this.Rbn_Cliente_Nenhuma.AutoSize = true;
            this.Rbn_Cliente_Nenhuma.Location = new System.Drawing.Point(8, 120);
            this.Rbn_Cliente_Nenhuma.Name = "Rbn_Cliente_Nenhuma";
            this.Rbn_Cliente_Nenhuma.Size = new System.Drawing.Size(92, 33);
            this.Rbn_Cliente_Nenhuma.TabIndex = 17;
            this.Rbn_Cliente_Nenhuma.TabStop = true;
            this.Rbn_Cliente_Nenhuma.Text = "Nenhuma";
            this.Rbn_Cliente_Nenhuma.UseVisualStyleBackColor = true;
            this.Rbn_Cliente_Nenhuma.CheckedChanged += new System.EventHandler(this.Rbn_Cliente_Nenhuma_CheckedChanged);
            // 
            // Rbn_Cliente_Exantema
            // 
            this.Rbn_Cliente_Exantema.AutoSize = true;
            this.Rbn_Cliente_Exantema.Location = new System.Drawing.Point(8, 97);
            this.Rbn_Cliente_Exantema.Name = "Rbn_Cliente_Exantema";
            this.Rbn_Cliente_Exantema.Size = new System.Drawing.Size(95, 33);
            this.Rbn_Cliente_Exantema.TabIndex = 17;
            this.Rbn_Cliente_Exantema.TabStop = true;
            this.Rbn_Cliente_Exantema.Text = "Exantema";
            this.Rbn_Cliente_Exantema.UseVisualStyleBackColor = true;
            this.Rbn_Cliente_Exantema.CheckedChanged += new System.EventHandler(this.Rbn_Cliente_Exantema_CheckedChanged);
            // 
            // Rbn_Cliente_Atopica
            // 
            this.Rbn_Cliente_Atopica.AutoSize = true;
            this.Rbn_Cliente_Atopica.Location = new System.Drawing.Point(8, 72);
            this.Rbn_Cliente_Atopica.Name = "Rbn_Cliente_Atopica";
            this.Rbn_Cliente_Atopica.Size = new System.Drawing.Size(153, 33);
            this.Rbn_Cliente_Atopica.TabIndex = 17;
            this.Rbn_Cliente_Atopica.TabStop = true;
            this.Rbn_Cliente_Atopica.Text = "Dermatite Atopica";
            this.Rbn_Cliente_Atopica.UseVisualStyleBackColor = true;
            this.Rbn_Cliente_Atopica.CheckedChanged += new System.EventHandler(this.Rbn_Cliente_Atopica_CheckedChanged);
            // 
            // Rbn_Cliente_Dermatite
            // 
            this.Rbn_Cliente_Dermatite.AutoSize = true;
            this.Rbn_Cliente_Dermatite.Location = new System.Drawing.Point(8, 47);
            this.Rbn_Cliente_Dermatite.Name = "Rbn_Cliente_Dermatite";
            this.Rbn_Cliente_Dermatite.Size = new System.Drawing.Size(174, 33);
            this.Rbn_Cliente_Dermatite.TabIndex = 17;
            this.Rbn_Cliente_Dermatite.TabStop = true;
            this.Rbn_Cliente_Dermatite.Text = "Dermatite de Contato";
            this.Rbn_Cliente_Dermatite.UseVisualStyleBackColor = true;
            this.Rbn_Cliente_Dermatite.CheckedChanged += new System.EventHandler(this.Rbn_Cliente_Dermatite_CheckedChanged);
            // 
            // Rbn_Cliente_Urticaria
            // 
            this.Rbn_Cliente_Urticaria.AutoSize = true;
            this.Rbn_Cliente_Urticaria.Location = new System.Drawing.Point(8, 22);
            this.Rbn_Cliente_Urticaria.Name = "Rbn_Cliente_Urticaria";
            this.Rbn_Cliente_Urticaria.Size = new System.Drawing.Size(91, 33);
            this.Rbn_Cliente_Urticaria.TabIndex = 0;
            this.Rbn_Cliente_Urticaria.TabStop = true;
            this.Rbn_Cliente_Urticaria.Text = "Urticária";
            this.Rbn_Cliente_Urticaria.UseVisualStyleBackColor = true;
            this.Rbn_Cliente_Urticaria.CheckedChanged += new System.EventHandler(this.Rbn_Cliente_Urticaria_CheckedChanged);
            // 
            // Lbl_Cadastro_Nascimento
            // 
            this.Lbl_Cadastro_Nascimento.AutoSize = true;
            this.Lbl_Cadastro_Nascimento.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cadastro_Nascimento.Location = new System.Drawing.Point(287, 162);
            this.Lbl_Cadastro_Nascimento.Name = "Lbl_Cadastro_Nascimento";
            this.Lbl_Cadastro_Nascimento.Size = new System.Drawing.Size(130, 29);
            this.Lbl_Cadastro_Nascimento.TabIndex = 16;
            this.Lbl_Cadastro_Nascimento.Text = "Data Nascimento:";
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 383);
            this.Controls.Add(this.Lbl_Cadastro_Nascimento);
            this.Controls.Add(this.Gbx_Cliente_Alergia);
            this.Controls.Add(this.Dtp_Cliente_Nascimento);
            this.Controls.Add(this.Mtb_Cliente_Tel);
            this.Controls.Add(this.Txt_Cliente_Bairro);
            this.Controls.Add(this.Lbl_Cliente_Bairro);
            this.Controls.Add(this.Lbl_Tel_Cliente);
            this.Controls.Add(this.Lbl_Nome_CLiente);
            this.Controls.Add(this.Txt_Cliente_Cadastro);
            this.Controls.Add(this.Lbl_Text_Client);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cadastro_Cliente";
            this.Text = "Cadastro_Cliente";
            this.Load += new System.EventHandler(this.Cadastro_Cliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gbx_Cliente_Alergia.ResumeLayout(false);
            this.Gbx_Cliente_Alergia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Text_Client;
        private TextBox Txt_Cliente_Cadastro;
        private Label Lbl_Nome_CLiente;
        private Label Lbl_Tel_Cliente;
        private Label Lbl_Cliente_Bairro;
        private TextBox Txt_Cliente_Bairro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modosToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem retornaToolStripMenuItem;
        private MaskedTextBox Mtb_Cliente_Tel;
        private DateTimePicker Dtp_Cliente_Nascimento;
        private GroupBox Gbx_Cliente_Alergia;
        private RadioButton Rbn_Cliente_Urticaria;
        private Label Lbl_Cadastro_Nascimento;
        private RadioButton Rbn_Cliente_Atopica;
        private RadioButton Rbn_Cliente_Dermatite;
        private RadioButton Rbn_Cliente_Exantema;
        private RadioButton Rbn_Cliente_Nenhuma;
    }
}