namespace Controle_Regina_Cliente.Servico
{
    partial class Servico_Cliente
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
            this.Lbl_Text_Servico = new System.Windows.Forms.Label();
            this.Txt_Nome_Servico = new System.Windows.Forms.TextBox();
            this.Lbl_Servico = new System.Windows.Forms.Label();
            this.Lbl_Descricao_Servico = new System.Windows.Forms.Label();
            this.Rtb_Descricao_Servico = new System.Windows.Forms.RichTextBox();
            this.Lbl_Preco_Servico = new System.Windows.Forms.Label();
            this.Txt_Preco_Servico = new System.Windows.Forms.TextBox();
            this.Btn_Salvar_Servico = new System.Windows.Forms.Button();
            this.Btn_Retornar_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Text_Servico
            // 
            this.Lbl_Text_Servico.AutoSize = true;
            this.Lbl_Text_Servico.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Text_Servico.Location = new System.Drawing.Point(136, 42);
            this.Lbl_Text_Servico.Name = "Lbl_Text_Servico";
            this.Lbl_Text_Servico.Size = new System.Drawing.Size(330, 47);
            this.Lbl_Text_Servico.TabIndex = 2;
            this.Lbl_Text_Servico.Text = "Cadastre os Serviços Prestados";
            // 
            // Txt_Nome_Servico
            // 
            this.Txt_Nome_Servico.Location = new System.Drawing.Point(144, 132);
            this.Txt_Nome_Servico.Name = "Txt_Nome_Servico";
            this.Txt_Nome_Servico.Size = new System.Drawing.Size(229, 23);
            this.Txt_Nome_Servico.TabIndex = 1;
            // 
            // Lbl_Servico
            // 
            this.Lbl_Servico.AutoSize = true;
            this.Lbl_Servico.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Servico.Location = new System.Drawing.Point(5, 128);
            this.Lbl_Servico.Name = "Lbl_Servico";
            this.Lbl_Servico.Size = new System.Drawing.Size(139, 34);
            this.Lbl_Servico.TabIndex = 4;
            this.Lbl_Servico.Text = "Nome do Serviço";
            this.Lbl_Servico.Click += new System.EventHandler(this.Lbl_Servico_Click);
            // 
            // Lbl_Descricao_Servico
            // 
            this.Lbl_Descricao_Servico.AutoSize = true;
            this.Lbl_Descricao_Servico.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Descricao_Servico.Location = new System.Drawing.Point(5, 208);
            this.Lbl_Descricao_Servico.Name = "Lbl_Descricao_Servico";
            this.Lbl_Descricao_Servico.Size = new System.Drawing.Size(169, 34);
            this.Lbl_Descricao_Servico.TabIndex = 6;
            this.Lbl_Descricao_Servico.Text = "Descrição do Serviço";
            // 
            // Rtb_Descricao_Servico
            // 
            this.Rtb_Descricao_Servico.Location = new System.Drawing.Point(180, 177);
            this.Rtb_Descricao_Servico.Name = "Rtb_Descricao_Servico";
            this.Rtb_Descricao_Servico.Size = new System.Drawing.Size(286, 96);
            this.Rtb_Descricao_Servico.TabIndex = 3;
            this.Rtb_Descricao_Servico.Text = "";
            this.Rtb_Descricao_Servico.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Lbl_Preco_Servico
            // 
            this.Lbl_Preco_Servico.AutoSize = true;
            this.Lbl_Preco_Servico.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Preco_Servico.Location = new System.Drawing.Point(376, 128);
            this.Lbl_Preco_Servico.Name = "Lbl_Preco_Servico";
            this.Lbl_Preco_Servico.Size = new System.Drawing.Size(139, 34);
            this.Lbl_Preco_Servico.TabIndex = 9;
            this.Lbl_Preco_Servico.Text = "Preço do Serviço";
            // 
            // Txt_Preco_Servico
            // 
            this.Txt_Preco_Servico.Location = new System.Drawing.Point(515, 132);
            this.Txt_Preco_Servico.Name = "Txt_Preco_Servico";
            this.Txt_Preco_Servico.Size = new System.Drawing.Size(91, 23);
            this.Txt_Preco_Servico.TabIndex = 2;
            // 
            // Btn_Salvar_Servico
            // 
            this.Btn_Salvar_Servico.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Salvar_Servico.Location = new System.Drawing.Point(518, 327);
            this.Btn_Salvar_Servico.Name = "Btn_Salvar_Servico";
            this.Btn_Salvar_Servico.Size = new System.Drawing.Size(75, 37);
            this.Btn_Salvar_Servico.TabIndex = 5;
            this.Btn_Salvar_Servico.Text = "Salvar";
            this.Btn_Salvar_Servico.UseVisualStyleBackColor = true;
            this.Btn_Salvar_Servico.Click += new System.EventHandler(this.Btn_Salvar_Servico_Click);
            // 
            // Btn_Retornar_Menu
            // 
            this.Btn_Retornar_Menu.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Retornar_Menu.Location = new System.Drawing.Point(25, 327);
            this.Btn_Retornar_Menu.Name = "Btn_Retornar_Menu";
            this.Btn_Retornar_Menu.Size = new System.Drawing.Size(81, 37);
            this.Btn_Retornar_Menu.TabIndex = 4;
            this.Btn_Retornar_Menu.Text = "Retorna";
            this.Btn_Retornar_Menu.UseVisualStyleBackColor = true;
            this.Btn_Retornar_Menu.Click += new System.EventHandler(this.Btn_Retornar_Menu_Click);
            // 
            // Servico_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 377);
            this.Controls.Add(this.Btn_Retornar_Menu);
            this.Controls.Add(this.Btn_Salvar_Servico);
            this.Controls.Add(this.Lbl_Preco_Servico);
            this.Controls.Add(this.Txt_Preco_Servico);
            this.Controls.Add(this.Rtb_Descricao_Servico);
            this.Controls.Add(this.Lbl_Descricao_Servico);
            this.Controls.Add(this.Lbl_Servico);
            this.Controls.Add(this.Txt_Nome_Servico);
            this.Controls.Add(this.Lbl_Text_Servico);
            this.Name = "Servico_Cliente";
            this.Text = "Servico_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Text_Servico;
        private TextBox Txt_Nome_Servico;
        private Label Lbl_Servico;
        private Label Lbl_Descricao_Servico;
        private RichTextBox Rtb_Descricao_Servico;
        private Label Lbl_Preco_Servico;
        private TextBox Txt_Preco_Servico;
        private Button Btn_Salvar_Servico;
        private Button Btn_Retornar_Menu;
    }
}