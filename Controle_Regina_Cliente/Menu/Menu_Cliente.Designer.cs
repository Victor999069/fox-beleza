namespace Controle_Regina_Cliente.Menu
{
    partial class Menu_Cliente
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
            this.Lbl_Text_Menu = new System.Windows.Forms.Label();
            this.Btn_Menu_Sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Stm_Cadastros_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stm_CadastroCliente_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stm_CadastroServico_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stm_Registros_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stm_Registro_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stm_Relatorios_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stm_Atendimento_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Text_Menu
            // 
            this.Lbl_Text_Menu.AutoSize = true;
            this.Lbl_Text_Menu.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Text_Menu.Location = new System.Drawing.Point(186, 56);
            this.Lbl_Text_Menu.Name = "Lbl_Text_Menu";
            this.Lbl_Text_Menu.Size = new System.Drawing.Size(434, 47);
            this.Lbl_Text_Menu.TabIndex = 0;
            this.Lbl_Text_Menu.Text = "Seja Bem Vindo ao Control System Client";
            // 
            // Btn_Menu_Sair
            // 
            this.Btn_Menu_Sair.Font = new System.Drawing.Font("Javanese Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Menu_Sair.Location = new System.Drawing.Point(12, 317);
            this.Btn_Menu_Sair.Name = "Btn_Menu_Sair";
            this.Btn_Menu_Sair.Size = new System.Drawing.Size(97, 39);
            this.Btn_Menu_Sair.TabIndex = 3;
            this.Btn_Menu_Sair.Text = "Sair";
            this.Btn_Menu_Sair.UseVisualStyleBackColor = true;
            this.Btn_Menu_Sair.Click += new System.EventHandler(this.Btn_Menu_Sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stm_Cadastros_Menu,
            this.Stm_Registros_Menu,
            this.Stm_Relatorios_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Stm_Cadastros_Menu
            // 
            this.Stm_Cadastros_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stm_CadastroCliente_Menu,
            this.Stm_CadastroServico_Menu});
            this.Stm_Cadastros_Menu.Name = "Stm_Cadastros_Menu";
            this.Stm_Cadastros_Menu.Size = new System.Drawing.Size(66, 20);
            this.Stm_Cadastros_Menu.Text = "Cadastro";
            // 
            // Stm_CadastroCliente_Menu
            // 
            this.Stm_CadastroCliente_Menu.Name = "Stm_CadastroCliente_Menu";
            this.Stm_CadastroCliente_Menu.Size = new System.Drawing.Size(180, 22);
            this.Stm_CadastroCliente_Menu.Text = "Cadastro Cliente";
            this.Stm_CadastroCliente_Menu.Click += new System.EventHandler(this.Stm_CadastroCliente_Menu_Click);
            // 
            // Stm_CadastroServico_Menu
            // 
            this.Stm_CadastroServico_Menu.Name = "Stm_CadastroServico_Menu";
            this.Stm_CadastroServico_Menu.Size = new System.Drawing.Size(180, 22);
            this.Stm_CadastroServico_Menu.Text = "Cadastro Serviço";
            this.Stm_CadastroServico_Menu.Click += new System.EventHandler(this.Stm_CadastroServico_Menu_Click);
            // 
            // Stm_Registros_Menu
            // 
            this.Stm_Registros_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stm_Registro_Menu});
            this.Stm_Registros_Menu.Name = "Stm_Registros_Menu";
            this.Stm_Registros_Menu.Size = new System.Drawing.Size(67, 20);
            this.Stm_Registros_Menu.Text = "Registros";
            // 
            // Stm_Registro_Menu
            // 
            this.Stm_Registro_Menu.Name = "Stm_Registro_Menu";
            this.Stm_Registro_Menu.Size = new System.Drawing.Size(180, 22);
            this.Stm_Registro_Menu.Text = "Registro Cliente";
            this.Stm_Registro_Menu.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // Stm_Relatorios_Menu
            // 
            this.Stm_Relatorios_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stm_Atendimento_Menu});
            this.Stm_Relatorios_Menu.Name = "Stm_Relatorios_Menu";
            this.Stm_Relatorios_Menu.Size = new System.Drawing.Size(71, 20);
            this.Stm_Relatorios_Menu.Text = "Relatorios";
            // 
            // Stm_Atendimento_Menu
            // 
            this.Stm_Atendimento_Menu.Name = "Stm_Atendimento_Menu";
            this.Stm_Atendimento_Menu.Size = new System.Drawing.Size(185, 22);
            this.Stm_Atendimento_Menu.Text = "Dados Atendimentos";
            this.Stm_Atendimento_Menu.Click += new System.EventHandler(this.dadosAtendimentosToolStripMenuItem_Click);
            // 
            // Menu_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.Btn_Menu_Sair);
            this.Controls.Add(this.Lbl_Text_Menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Cliente";
            this.Text = "Menu_Cliente";
            this.Load += new System.EventHandler(this.Menu_Cliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Text_Menu;
        private Button Btn_Menu_Sair;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Stm_Cadastros_Menu;
        private ToolStripMenuItem Stm_CadastroCliente_Menu;
        private ToolStripMenuItem Stm_CadastroServico_Menu;
        private ToolStripMenuItem Stm_Registros_Menu;
        private ToolStripMenuItem Stm_Registro_Menu;
        private ToolStripMenuItem Stm_Relatorios_Menu;
        private ToolStripMenuItem Stm_Atendimento_Menu;
    }
}