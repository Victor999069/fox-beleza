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
            this.Btn_Registra_Cliente = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Serviço = new System.Windows.Forms.Button();
            this.Btn_Menu_Sair = new System.Windows.Forms.Button();
            this.Btn_Apresentacao = new System.Windows.Forms.Button();
            this.Btn_Menu_Input = new System.Windows.Forms.Button();
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
            // Btn_Registra_Cliente
            // 
            this.Btn_Registra_Cliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Btn_Registra_Cliente.Location = new System.Drawing.Point(181, 165);
            this.Btn_Registra_Cliente.Name = "Btn_Registra_Cliente";
            this.Btn_Registra_Cliente.Size = new System.Drawing.Size(97, 75);
            this.Btn_Registra_Cliente.TabIndex = 1;
            this.Btn_Registra_Cliente.Text = "Registrar CLiente";
            this.Btn_Registra_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Registra_Cliente.Click += new System.EventHandler(this.Btn_Registra_Cliente_Click);
            // 
            // Btn_Cadastrar_Serviço
            // 
            this.Btn_Cadastrar_Serviço.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Btn_Cadastrar_Serviço.Location = new System.Drawing.Point(294, 165);
            this.Btn_Cadastrar_Serviço.Name = "Btn_Cadastrar_Serviço";
            this.Btn_Cadastrar_Serviço.Size = new System.Drawing.Size(97, 75);
            this.Btn_Cadastrar_Serviço.TabIndex = 2;
            this.Btn_Cadastrar_Serviço.Text = "Registrar Serviço";
            this.Btn_Cadastrar_Serviço.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar_Serviço.Click += new System.EventHandler(this.Btn_Cadastrar_Serviço_Click);
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
            // Btn_Apresentacao
            // 
            this.Btn_Apresentacao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Btn_Apresentacao.Location = new System.Drawing.Point(523, 165);
            this.Btn_Apresentacao.Name = "Btn_Apresentacao";
            this.Btn_Apresentacao.Size = new System.Drawing.Size(97, 75);
            this.Btn_Apresentacao.TabIndex = 4;
            this.Btn_Apresentacao.Text = "Analisar Dados";
            this.Btn_Apresentacao.UseVisualStyleBackColor = true;
            this.Btn_Apresentacao.Click += new System.EventHandler(this.Btn_Apresentacao_Click);
            // 
            // Btn_Menu_Input
            // 
            this.Btn_Menu_Input.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Btn_Menu_Input.Location = new System.Drawing.Point(408, 165);
            this.Btn_Menu_Input.Name = "Btn_Menu_Input";
            this.Btn_Menu_Input.Size = new System.Drawing.Size(97, 75);
            this.Btn_Menu_Input.TabIndex = 5;
            this.Btn_Menu_Input.Text = "Registre Seu Atendimento";
            this.Btn_Menu_Input.UseVisualStyleBackColor = true;
            this.Btn_Menu_Input.Click += new System.EventHandler(this.Btn_Menu_Input_Click);
            // 
            // Menu_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.Btn_Menu_Input);
            this.Controls.Add(this.Btn_Apresentacao);
            this.Controls.Add(this.Btn_Menu_Sair);
            this.Controls.Add(this.Btn_Cadastrar_Serviço);
            this.Controls.Add(this.Btn_Registra_Cliente);
            this.Controls.Add(this.Lbl_Text_Menu);
            this.Name = "Menu_Cliente";
            this.Text = "Menu_Cliente";
            this.Load += new System.EventHandler(this.Menu_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Text_Menu;
        private Button Btn_Registra_Cliente;
        private Button Btn_Cadastrar_Serviço;
        private Button Btn_Menu_Sair;
        private Button Btn_Apresentacao;
        private Button Btn_Menu_Input;
    }
}