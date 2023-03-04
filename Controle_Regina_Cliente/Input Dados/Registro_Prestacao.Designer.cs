namespace Controle_Regina_Cliente.Input_Dados
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
            this.Txt_Registro_Cliente = new System.Windows.Forms.TextBox();
            this.Lbl_Input_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Input_Servico = new System.Windows.Forms.Label();
            this.Cb_Registro_Servico = new System.Windows.Forms.ComboBox();
            this.Lbl_Input_Tel = new System.Windows.Forms.Label();
            this.Txt_Registro_Tel = new System.Windows.Forms.TextBox();
            this.Lbl_Input_Preco = new System.Windows.Forms.Label();
            this.Txt_Registro_Prc = new System.Windows.Forms.TextBox();
            this.Lbl_Input_Desconto = new System.Windows.Forms.Label();
            this.Txt_Registro_Desconto = new System.Windows.Forms.TextBox();
            this.Btn_Prestacao_Retorna = new System.Windows.Forms.Button();
            this.Lbl_Prestacao_Inicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Registro_Cliente
            // 
            this.Txt_Registro_Cliente.Location = new System.Drawing.Point(123, 126);
            this.Txt_Registro_Cliente.Name = "Txt_Registro_Cliente";
            this.Txt_Registro_Cliente.Size = new System.Drawing.Size(148, 23);
            this.Txt_Registro_Cliente.TabIndex = 0;
            // 
            // Lbl_Input_Cliente
            // 
            this.Lbl_Input_Cliente.AutoSize = true;
            this.Lbl_Input_Cliente.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Cliente.Location = new System.Drawing.Point(12, 126);
            this.Lbl_Input_Cliente.Name = "Lbl_Input_Cliente";
            this.Lbl_Input_Cliente.Size = new System.Drawing.Size(103, 29);
            this.Lbl_Input_Cliente.TabIndex = 1;
            this.Lbl_Input_Cliente.Text = "Nome Cliente";
            this.Lbl_Input_Cliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Input_Servico
            // 
            this.Lbl_Input_Servico.AutoSize = true;
            this.Lbl_Input_Servico.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Servico.Location = new System.Drawing.Point(280, 126);
            this.Lbl_Input_Servico.Name = "Lbl_Input_Servico";
            this.Lbl_Input_Servico.Size = new System.Drawing.Size(122, 29);
            this.Lbl_Input_Servico.TabIndex = 3;
            this.Lbl_Input_Servico.Text = "Serviço Prestado";
            // 
            // Cb_Registro_Servico
            // 
            this.Cb_Registro_Servico.FormattingEnabled = true;
            this.Cb_Registro_Servico.Location = new System.Drawing.Point(400, 126);
            this.Cb_Registro_Servico.Name = "Cb_Registro_Servico";
            this.Cb_Registro_Servico.Size = new System.Drawing.Size(188, 23);
            this.Cb_Registro_Servico.TabIndex = 4;
            this.Cb_Registro_Servico.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Txt_Registro_Tel
            // 
            this.Txt_Registro_Tel.Location = new System.Drawing.Point(123, 189);
            this.Txt_Registro_Tel.Name = "Txt_Registro_Tel";
            this.Txt_Registro_Tel.Size = new System.Drawing.Size(148, 23);
            this.Txt_Registro_Tel.TabIndex = 5;
            this.Txt_Registro_Tel.TextChanged += new System.EventHandler(this.Txt_Input_Tel_TextChanged);
            // 
            // Lbl_Input_Preco
            // 
            this.Lbl_Input_Preco.AutoSize = true;
            this.Lbl_Input_Preco.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Preco.Location = new System.Drawing.Point(449, 189);
            this.Lbl_Input_Preco.Name = "Lbl_Input_Preco";
            this.Lbl_Input_Preco.Size = new System.Drawing.Size(50, 29);
            this.Lbl_Input_Preco.TabIndex = 8;
            this.Lbl_Input_Preco.Text = "Preço";
            // 
            // Txt_Registro_Prc
            // 
            this.Txt_Registro_Prc.Location = new System.Drawing.Point(500, 189);
            this.Txt_Registro_Prc.Name = "Txt_Registro_Prc";
            this.Txt_Registro_Prc.Size = new System.Drawing.Size(69, 23);
            this.Txt_Registro_Prc.TabIndex = 7;
            // 
            // Lbl_Input_Desconto
            // 
            this.Lbl_Input_Desconto.AutoSize = true;
            this.Lbl_Input_Desconto.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Desconto.Location = new System.Drawing.Point(287, 189);
            this.Lbl_Input_Desconto.Name = "Lbl_Input_Desconto";
            this.Lbl_Input_Desconto.Size = new System.Drawing.Size(74, 29);
            this.Lbl_Input_Desconto.TabIndex = 10;
            this.Lbl_Input_Desconto.Text = "Desconto";
            this.Lbl_Input_Desconto.Click += new System.EventHandler(this.Lbl_Input_Desconto_Click);
            // 
            // Txt_Registro_Desconto
            // 
            this.Txt_Registro_Desconto.Location = new System.Drawing.Point(363, 189);
            this.Txt_Registro_Desconto.Name = "Txt_Registro_Desconto";
            this.Txt_Registro_Desconto.Size = new System.Drawing.Size(75, 23);
            this.Txt_Registro_Desconto.TabIndex = 9;
            this.Txt_Registro_Desconto.TextChanged += new System.EventHandler(this.Txt_Input_Desconto_TextChanged);
            // 
            // Btn_Prestacao_Retorna
            // 
            this.Btn_Prestacao_Retorna.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Prestacao_Retorna.Location = new System.Drawing.Point(12, 252);
            this.Btn_Prestacao_Retorna.Name = "Btn_Prestacao_Retorna";
            this.Btn_Prestacao_Retorna.Size = new System.Drawing.Size(86, 33);
            this.Btn_Prestacao_Retorna.TabIndex = 11;
            this.Btn_Prestacao_Retorna.Text = "Retorna";
            this.Btn_Prestacao_Retorna.UseVisualStyleBackColor = true;
            this.Btn_Prestacao_Retorna.Click += new System.EventHandler(this.button1_Click);
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
            // Registro_Prestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.Lbl_Prestacao_Inicial);
            this.Controls.Add(this.Btn_Prestacao_Retorna);
            this.Controls.Add(this.Lbl_Input_Desconto);
            this.Controls.Add(this.Txt_Registro_Desconto);
            this.Controls.Add(this.Lbl_Input_Preco);
            this.Controls.Add(this.Txt_Registro_Prc);
            this.Controls.Add(this.Lbl_Input_Tel);
            this.Controls.Add(this.Txt_Registro_Tel);
            this.Controls.Add(this.Cb_Registro_Servico);
            this.Controls.Add(this.Lbl_Input_Servico);
            this.Controls.Add(this.Lbl_Input_Cliente);
            this.Controls.Add(this.Txt_Registro_Cliente);
            this.Name = "Registro_Prestacao";
            this.Text = "Input_Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_Registro_Cliente;
        private Label Lbl_Input_Cliente;
        private Label Lbl_Input_Servico;
        private ComboBox Cb_Registro_Servico;
        private Label Lbl_Input_Tel;
        private TextBox Txt_Registro_Tel;
        private Label Lbl_Input_Preco;
        private TextBox Txt_Registro_Prc;
        private Label Lbl_Input_Desconto;
        private TextBox Txt_Registro_Desconto;
        private Button Btn_Prestacao_Retorna;
        private Label Lbl_Prestacao_Inicial;
    }
}